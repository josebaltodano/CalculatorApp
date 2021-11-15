﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
   public  interface IIntegralService
    {
        char Cadena(ref string a);
        void AddC(ref string rtb, string txtI, ref string txt);
        void ObtenerSimb(string rtb);
        void AddA(int p);
        double Integral(char fun, double limI, double limS);
        void valor(string txtI);
        double OperarDentroParen(double Inferior, double Superior, int np);
        void EscribirVariab(ref string rtb);
        double IntegralesPolin(List<double> a, int n, double limitInf, double limitSup);
        void ObtenerNume(string rtb);
        char Signos(string cont, char direcc);
        void Reiniciar(ref string txtIn, ref string txtSu, ref bool txtI, ref bool txtS);
        void Variable(string rtbOperacion, string txtInferior);
        void GuardarnumInteg(string txt, string button, string rtb);
        void Igual(ref string txt, ref string rtb, string txtI, string txtS);
        int GradoPolin(string rtb);
        void Operaciones(ref string txt, ref string rtb, string button, string txtI);
        void OperacionesCien(ref string txt, ref string rtb, string btn);
        void Verificar(string txtI, string txtS, string rtb);
        List<double> GetValorX();
        List<double> GetValorY();

    }
}
