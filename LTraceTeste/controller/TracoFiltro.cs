using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LTraceTeste.service;
using Accord.Audio.Filters;
using Accord.Audio;

namespace LTraceTeste.controller
{
    public class TracoFiltro
    {
        static public float[] FiltraDados(float[] dados, double low_band, double high_band, int sampleRate) {
            var signal = Signal.FromArray(dados, sampleRate);

            var low_filter = new LowPassFilter(low_band, sampleRate);
            var high_filter = new HighPassFilter(high_band, sampleRate);

            signal = high_filter.Apply(signal);
            signal = low_filter.Apply(signal);

            return signal.ToFloat();
        }
    }
}
