using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class IntegralService : IIntegralService
    {
        private IIntegral intregal;

        public IntegralService(IIntegral intregal)
        {
            this.intregal = intregal;
        }

        public void AddA(int p)
        {
            intregal.AddA(p);
        }

        public void AddC(ref string rtb, string txtI, ref string txt)
        {
            intregal.AddC(ref rtb, txtI, ref txt);
        }

        public char Cadena(ref string a)
        {
            return intregal.Cadena( ref a);
        }

        public List<double> DeleteX()
        {
            return intregal.DeleteX();
        }

        public List<double> DeleteY()
        {
            return intregal.DeleteY();
        }

        public void EscribirVariab(ref string rtb)
        {
            intregal.EscribirVariab(ref rtb);
        }

        public List<double> GetValorX()
        {
            return intregal.GetValorX();
        }

        public List<double> GetValorY()
        {
            return intregal.GetValorY();
        }

       /* public int GradoPolin(string rtb)
        {
            return intregal.GradoPolin(rtb);
        }*/

        public void GuardarnumInteg(string txt, string button, string rtb)
        {
            intregal.GuardarnumInteg(txt, button, rtb);
        }

        public void Igual(ref string txt, ref string rtb, string txtI, string txtS)
        {
            intregal.Igual(ref txt, ref rtb, txtI, txtS);
        }

        public double Integral(char fun, double limI, double limS)
        {
            return intregal.Integral(fun, limI, limS);
        }

        public double IntegralesPolin(List<double> a, int n, double limitInf, double limitSup)
        {
            return intregal.IntegralesPolin(a, n, limitInf, limitSup);
        }

        public void ObtenerNume(string rtb)
        {
            intregal.ObtenerNume(rtb);
        }

        public void Operaciones(ref string txt, ref string rtb, string button, string txtI)
        {
            intregal.Operaciones(ref txt, ref rtb, button, txtI);
        }

        public void OperacionesCien(ref string txt, ref string rtb, string btn)
        {
            intregal.OperacionesCien(ref txt, ref rtb, btn);
        }

        public void Reiniciar(ref string txtIn, ref string txtSu, ref bool txtI, ref bool txtS)
        {
            intregal.Reiniciar(ref txtIn, ref txtSu, ref txtI, ref txtS);
        }

        public char Signos(string cont, char direcc)
        {
            return intregal.Signos(cont, direcc);
        }

        public void valor(string txtI)
        {
            intregal.valor(txtI);
        }

        public void Variable(string rtbOperacion, string txtInferior)
        {
            intregal.Variable(rtbOperacion, txtInferior);
        }

        public void Verificar(string txtI, string txtS, string rtb)
        {
            intregal.Verificar(txtI, txtS, rtb);
        }
    }
}
