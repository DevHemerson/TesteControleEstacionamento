using ControleEstacionamento.Application.Interfaces;
using ControleEstacionamento.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstacionamento.IoC
{
    public static class NativeInjector
    {
        public static void RgisterService(IServiceCollection service)
        {
            service.AddScoped<IVeiculoService, VeiculoService();
        }
    }
}
