using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Accord.Math;
using System.Windows.Forms;
using System.Globalization;

namespace LTraceTeste.service
{
    internal class TracosArquivo : ITracoService
    {
        private List<double> tracos;

        public bool SaveSupported() { return true; }

        public double[] GetTracos() { return tracos.ToArray(); }

        public bool SalvarResultados(float[] data, string path) {
            var csv = new StringBuilder();
            foreach (double d in data) {
                csv.AppendLine(d.ToString("E3"));
            }

            try
            {
                File.WriteAllText(path, csv.ToString());
            }catch(SystemException) {
                return false;
            }

            return true; 
        }

        public TracosArquivo()
        {
            tracos = new List<double>();
        }

        public bool CarregarArquivo(string path, bool ignore_first_line = true)
        {
            try { 
                var lines = File.ReadAllLines(path);

                if (ignore_first_line)
                    lines = lines.Skip(1).ToArray();

                double result;
                foreach (string element in lines)
                {
                    if (!double.TryParse(element, System.Globalization.NumberStyles.Float, CultureInfo.CurrentCulture, out result) &&
                        //Then try in US english
                        !double.TryParse(element, System.Globalization.NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out result) &&
                        //Then in neutral language
                        !double.TryParse(element, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out result))
                    {
                        throw new SystemException();
                    }
                    tracos.Add(result);
                }
            } catch (SystemException)
            {
                MessageBox.Show("Falha ao carregar");
                return false;
            }

            MessageBox.Show("Carregado com Sucesso");
            return true;
        }

    }
}
