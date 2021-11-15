using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using CalculadoraApp.Formularios;
using Domain.Interfaces;
using Infraestructura.Metodos;

namespace CalculadoraApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MetodoDeOperaciones>().As<IOperaciones>();
            builder.RegisterType<MetodosDeOperacionesServices>().As<IOperacionesServices>();

            builder.RegisterType<IntegralesModel>().As<IIntegral>();
            builder.RegisterType<IntegralService>().As<IIntegralService>();

            var container = builder.Build();

     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BasicCalculatorForm(container.Resolve<IOperacionesServices>(), container.Resolve<IIntegralService>()));
            //Application.Run(new BasicCalculatorForm());
        }
    }
}
