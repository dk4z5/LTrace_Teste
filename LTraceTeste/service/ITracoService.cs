using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTraceTeste.service
{
    interface ITracoService
    {
        double[] GetTracos();

        bool SaveSupported();

        bool SalvarResultados(float[] tracos, string path);
    }
}
