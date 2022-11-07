using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using LTraceTeste.controller;
using Accord;
using Accord.Math;
using System.Runtime.InteropServices;
using Accord.Audio;
using System.IO;

namespace LTraceTeste
{
    public partial class FiltroWindow : Form
    {
        private float freq_low, freq_high;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;

        public FiltroWindow()
        {
            InitializeComponent();

            chart.AddDataSeries("wave_filtered",  Color.Red,   Accord.Controls.Chart.SeriesType.Line, 1);
            chart.AddDataSeries("wave_no_filter", Color.Blue,  Accord.Controls.Chart.SeriesType.Line, 1);

            check_Rotate.Checked = Properties.Settings.Default.chk_transpose;

            text_highFilter.Text = Properties.Settings.Default.freq_high.ToString();
            text_lowFilter.Text  = Properties.Settings.Default.freq_low.ToString();
        }

        private void UpdateGrafico()
        {
            var dados_n_filtrados = Array.ConvertAll(Servicos.GetInstance().Traco, x => (float)x);

            if (dados_n_filtrados.Length == 0)
            {
                chart.UpdateDataSeries("wave_filtered", null);
                chart.UpdateDataSeries("wave_no_filter", null);
                MessageBox.Show("Sem dados para a análise, verifique a fonte de dados.");
                return;
            }

            // Freq = 1 / T, onde T=4ms, assim temos Freq = 1/0.004 = 250
            var dados_filtrados = TracoFiltro.FiltraDados(dados_n_filtrados, freq_low, freq_high, 250);


            Signal sig = Signal.FromArray(dados_n_filtrados, 1, 250);
            var vec_no_filter = sig.ToFloat();

            var x_range_filter = Math.Max(dados_filtrados.Min(), dados_filtrados.Max());
            var x_range_no_filter = Math.Max(vec_no_filter.Min(), vec_no_filter.Max());
            var x_range = Math.Max(x_range_filter, x_range_no_filter)*1.2f;

            // Copia o range para os labels de amplitude, equivalente a "%f.2"
            lbl_amp_a.Text = lbl_amp_b.Text = x_range.ToString("F2");

            var mat_filt = Utilidade.Matriz_View(dados_filtrados, !check_Rotate.Checked);
            var mat_n_filt = Utilidade.Matriz_View(dados_n_filtrados, !check_Rotate.Checked);

            chart.UpdateDataSeries("wave_filtered", mat_filt);
            chart.UpdateDataSeries("wave_no_filter", mat_n_filt);

            if (!check_Rotate.Checked) { 
                chart.RangeY = new Range(0, dados_filtrados.Length);
                chart.RangeX = new Range(-x_range, x_range);
            } else {
                chart.RangeX = new Range(0, dados_filtrados.Length);
                chart.RangeY = new Range(-x_range, x_range);
            }
        }

        private void FiltroWindow_Load(object sender, EventArgs e)
        {
            UpdateGrafico();
        }

        private void check_Transpose_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.chk_transpose = check_Rotate.Checked;
            Properties.Settings.Default.Save();
            UpdateGrafico();
        }

        private static float float_conv(string s, float def) {
            float val;
            if (float.TryParse(s, out val))
                return val;
            return def;
        }

        private void text_lowFilter_TextChanged(object sender, EventArgs e)
        {
            freq_low = Properties.Settings.Default.freq_low = float_conv(text_lowFilter.Text, 0);
            Properties.Settings.Default.Save();
            slider_low.Value = (int)freq_low;
            UpdateGrafico();
        }

        private void abrir_MenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Title = "Arquivo de texto / CSV Sem cabeçalho";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt| Arquivo CSV *.csv|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Servicos.GetInstance().arquivo.CarregarArquivo(openFileDialog1.FileName);
        }

        private void comHeader_MenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Title = "CSV com cabeçalho";
            openFileDialog1.Filter = "Arquivo CSV *.csv|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Servicos.GetInstance().arquivo.CarregarArquivo(openFileDialog1.FileName, true);
        }

        private void database_MenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado.");
        }

        private void mockData_MenuItem_Click(object sender, EventArgs e)
        {
            Servicos.GetInstance().UsarMockData();
            UpdateGrafico();
        }

        private void arquivoDeEntr_MenuItem_Click(object sender, EventArgs e)
        {
            Servicos.GetInstance().UsarArquivos();
            UpdateGrafico();
        }

        private void salvar_MenuItem_Click(object sender, EventArgs e)
        {
            var svc = Servicos.GetInstance().service;

            if (!svc.SaveSupported())
            {
                MessageBox.Show("Porfavor selecione outra fonte de dados");
                return;
            }

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Arquivo CSV |*.csv";
            saveFileDialog1.Title = "Salvar Arquivo CSV";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                var dados_n_filtrados = Array.ConvertAll(Servicos.GetInstance().Traco, x => (float)x);
                var dados_filtrados = TracoFiltro.FiltraDados(dados_n_filtrados, freq_low, freq_high, 250);
                if ( svc.SalvarResultados(dados_filtrados, saveFileDialog1.FileName) )
                {
                    MessageBox.Show("Arquivo salvo com sucesso!");
                    return;
                }
                MessageBox.Show("Falha ao salvar arquivo");
            }
        }

        private void slider_low_Scroll(object sender, EventArgs e)
        {
            freq_low = Properties.Settings.Default.freq_low = slider_low.Value;
            Properties.Settings.Default.Save();
            text_lowFilter.Text = freq_low.ToString();
            UpdateGrafico();
        }

        private void slider_high_Scroll(object sender, EventArgs e)
        {
            freq_high = Properties.Settings.Default.freq_high = slider_high.Value;
            Properties.Settings.Default.Save();
            text_highFilter.Text = freq_high.ToString();
            UpdateGrafico();
        }

        private void text_highFilter_TextChanged(object sender, EventArgs e)
        {
            freq_high = Properties.Settings.Default.freq_high = float_conv(text_highFilter.Text, 25);
            slider_high.Value = (int)freq_high;
            Properties.Settings.Default.Save();
            UpdateGrafico();
        }
    }
}
