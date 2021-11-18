using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public  interface IOperacionesServices
    {
        void Ang(char an);
        void Guardarnum(double num);
        double Resultado();
        void MasMenos(ref string txt, ref string rt);
        void OperacionesCien(ref string txt, ref string rtb, string btn);
        void Igual(ref string txt, ref string rtb);
        void Quitar(ref string txt, ref string rtb);
        void Operaciones(ref string txt, ref string rtb, string button, string txtI);
        void ViewNumber(ref string txt, ref string rtb, string button);
        void ParentesisT(ref string cos, ref string sen, ref string tan, string rtb, ref string cosh, ref string senh, ref string tanh);
        void Reiniciar();
        int GradoPolin(string rtb);
        char GetOperador();

    }
}
