﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CalculadoraApp.Formularios
{
    public partial class GraphicsForm : Form
    {
        List<double> X = new List<double>();
        List<double> Y = new List<double>();
        double LimitS = 0;
        double LimitI = 0;
        double R = 0;
        public GraphicsForm(List<double> x, List<double> y,double limitI,double limitS,double r)
        {
            X = x;
            Y = y;
            R = r;
            LimitI = limitI;
            LimitS = limitS;
            InitializeComponent();
        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXComien = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinal = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYComien = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinal = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXComien, posXFinal);
                    yAxis.ScaleView.Zoom(posYComien, posYFinal);
                }
            }
            catch { }
        }
        public void StartZoom()
        {
            cViewArea.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            cViewArea.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            cViewArea.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            cViewArea.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            cViewArea.ChartAreas[0].AxisX.ScaleView.Zoom(-10, 10);
            cViewArea.ChartAreas[0].AxisY.ScaleView.Zoom(-10, 10);
        }
        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            try
            {
                StartZoom();
                cViewArea.MouseWheel += chart1_MouseWheel;
                cViewArea.ChartAreas["ChartArea1"].AxisY.Interval = 1; // Intervalo en el eje Y
                cViewArea.ChartAreas["ChartArea1"].AxisX.Interval = 1; // Intervalo en el eje X
                if (Math.Abs(R) < 10)
                {
                    R = 10;
                }
                double neg = LimitI - Math.Round(Math.Abs(R));
                double pos = LimitS + Math.Round(Math.Abs(R));
                if (pos > 10000)
                {
                    //throw new ArgumentException("Lo sentimos, no se puede grafica ese area en este momento");
                    pos = 2000;
                    neg = -2000;

                }
                cViewArea.ChartAreas["ChartArea1"].AxisY.Minimum = (neg/2);
                cViewArea.ChartAreas["ChartArea1"].AxisY.Maximum = pos/2;
                cViewArea.ChartAreas["ChartArea1"].AxisX.Minimum = neg/2;
                cViewArea.ChartAreas["ChartArea1"].AxisX.Maximum = pos / 2;
                CreateEjes();
               // GraficFuncion();
                GraficArea();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        public void CreateEjes()
        {
            double neg = LimitI - Math.Round(Math.Abs(R));
            double pos = LimitS + Math.Round(Math.Abs(R));
            if (pos>10000)
            {
                pos = 1000;
                neg = -1000;

            }
            for (double i = neg; i < pos; i++)
            {
                cViewArea.Series["EjeY"].Color = Color.Blue;
                cViewArea.Series["EjeX"].Color = Color.Red;
                cViewArea.Series["EjeY"].Points.AddXY(0, i);
                cViewArea.Series["EjeX"].Points.AddXY(i, 0);
            }
        }
        public void GraficArea()
        {
            for (int i = 0; i < Y.Count; i++)
            {
                cViewArea.Series["Area"].Points.AddXY(X[i], Y[i]);
            }
        }
        public void GraficFuncion()
        {
            for (int i = 0; i < Y.Count; i++)
            {
                cViewArea.Series["Fx"].Color = Color.Black;
                cViewArea.Series["Fx"].Points.AddXY(X[i], Y[i]);
            }
        }

    }
}
