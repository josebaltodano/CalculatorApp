using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IIntegral
    {
        char Cadena(ref string a);
        void AddC(ref string rtb, string txtI, ref string txt);
        void AddA(int p);
        double Integral(char fun, double limI, double limS);
        void valor(string txtI);
        void EscribirVariab(ref string rtb);
        double IntegralesPolin(List<double> a, int n, double limitInf, double limitSup);
        void ObtenerNume(string rtb);
        char Signos(string cont, char direcc);
        void Reiniciar(ref string txtIn, ref string txtSu, ref bool txtI, ref bool txtS);
        void Variable(string rtbOperacion, string txtInferior);
        void GuardarnumInteg(string txt, string button, string rtb);
        void Igual(ref string txt, ref string rtb, string txtI, string txtS);
       // int GradoPolin(string rtb);
        void Operaciones(ref string txt, ref string rtb, string button, string txtI);
        void OperacionesCien(ref string txt, ref string rtb, string btn);
        void Verificar(string txtI, string txtS, string rtb);
        List<double> GetValorX();
        List<double> GetValorY();
        List<double> DeleteX();
        List<double> DeleteY();
    }
}
