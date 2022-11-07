using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LTraceTeste.service;

namespace LTraceTeste.controller
{
    internal class Servicos
    {
        public Servicos()
        {
            traco = new TracosMock();
            arquivo = new TracosArquivo();
        }

        private static Servicos _self;
        private ITracoService traco;
        public double[] Traco { get => traco.GetTracos(); }
        public ITracoService service { get => traco; }

        public static Servicos GetInstance()
        {
            if (_self == null)
            {
                _self = new Servicos();
            }
            return _self;
        }

        public TracosArquivo arquivo;

        public void UsarMockData()
        {
            traco = new TracosMock();
        }

        public void UsarArquivos()
        {
            traco = arquivo;
        }
    }
}
