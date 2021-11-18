using AppCore.Interfaces;
using Domain.Interfaces;
using Infraestructura.Metodos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class MetodosDeOperacionesServices : IOperacionesServices
    {
        private IOperaciones operaciones;

        public MetodosDeOperacionesServices(IOperaciones operaciones)
        {
            this.operaciones = operaciones;
        }

        public void Ang(char an)
        {
            operaciones.Ang(an);
        }

        public char GetOperador()
        {
            return operaciones.GetOperador();
        }

        public int GradoPolin(string rtb)
        {
            return operaciones.GradoPolin(rtb);
        }

        public void Guardarnum(double num)
        {
            operaciones.Guardarnum(num);
        }

        public void Igual(ref string txt, ref string rtb)
        {
            operaciones.Igual(ref txt, ref rtb);
        }

        public void MasMenos(ref string txt, ref string rt)
        {
            operaciones.MasMenos(ref txt, ref rt);
        }

        public void Operaciones(ref string txt, ref string rtb, string button, string txtI)
        {
            operaciones.Operaciones(ref txt, ref rtb, button,  txtI);
        }

        public void OperacionesCien(ref string txt, ref string rtb, string btn)
        {
            operaciones.OperacionesCien(ref txt, ref rtb, btn);
        }

        public void ParentesisT(ref string cos, ref string sen, ref string tan, string rtb,ref string cosh,ref string senh,ref string tanh)
        {
            operaciones.ParentesisT(ref cos, ref sen, ref tan, rtb,ref cosh,ref senh,ref tanh);
        }

        public void Quitar(ref string txt, ref string rtb)
        {
            operaciones.Quitar(ref txt, ref rtb);
        }

        public void Reiniciar()
        {
            operaciones.Reiniciar();
        }

        public double Resultado()
        {
            return operaciones.Resultado();
        }

        public void ViewNumber(ref string txt, ref string rtb, string button)
        {
            operaciones.ViewNumber(ref txt, ref rtb, button);
        }
    }
}
