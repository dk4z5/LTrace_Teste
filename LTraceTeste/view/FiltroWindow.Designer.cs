namespace LTraceTeste
{
    partial class FiltroWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mockDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoDeEntrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new Accord.Controls.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.slider_low = new System.Windows.Forms.TrackBar();
            this.slider_high = new System.Windows.Forms.TrackBar();
            this.check_Rotate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_highFilter = new System.Windows.Forms.TextBox();
            this.text_lowFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_amp_b = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_amp_a = new System.Windows.Forms.Label();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.lbl_ms_high = new System.Windows.Forms.Label();
            this.lbl_ms_low = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_high)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.fonteDeDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.salvarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.abrirToolStripMenuItem.Text = "Abrir (Linha a Linha)";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrir_MenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comHeaderToolStripMenuItem,
            this.semHeaderToolStripMenuItem});
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // comHeaderToolStripMenuItem
            // 
            this.comHeaderToolStripMenuItem.Name = "comHeaderToolStripMenuItem";
            this.comHeaderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.comHeaderToolStripMenuItem.Text = "Com Header";
            this.comHeaderToolStripMenuItem.Click += new System.EventHandler(this.comHeader_MenuItem_Click);
            // 
            // semHeaderToolStripMenuItem
            // 
            this.semHeaderToolStripMenuItem.Name = "semHeaderToolStripMenuItem";
            this.semHeaderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.semHeaderToolStripMenuItem.Text = "Sem Header";
            this.semHeaderToolStripMenuItem.Click += new System.EventHandler(this.abrir_MenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salvarToolStripMenuItem.Text = "Salvar Resultado";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvar_MenuItem_Click);
            // 
            // fonteDeDadosToolStripMenuItem
            // 
            this.fonteDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mockDataToolStripMenuItem,
            this.arquivoDeEntrToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.fonteDeDadosToolStripMenuItem.Name = "fonteDeDadosToolStripMenuItem";
            this.fonteDeDadosToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.fonteDeDadosToolStripMenuItem.Text = "Fonte de Dados";
            // 
            // mockDataToolStripMenuItem
            // 
            this.mockDataToolStripMenuItem.Name = "mockDataToolStripMenuItem";
            this.mockDataToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mockDataToolStripMenuItem.Text = "Mock Data";
            this.mockDataToolStripMenuItem.Click += new System.EventHandler(this.mockData_MenuItem_Click);
            // 
            // arquivoDeEntrToolStripMenuItem
            // 
            this.arquivoDeEntrToolStripMenuItem.Name = "arquivoDeEntrToolStripMenuItem";
            this.arquivoDeEntrToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.arquivoDeEntrToolStripMenuItem.Text = "Arquivo de Entrada";
            this.arquivoDeEntrToolStripMenuItem.Click += new System.EventHandler(this.arquivoDeEntr_MenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.databaseToolStripMenuItem.Text = "Banco de Dados";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.database_MenuItem_Click);
            // 
            // chart
            // 
            this.chart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chart.Location = new System.Drawing.Point(78, 84);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(238, 382);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.slider_low);
            this.groupBox1.Controls.Add(this.slider_high);
            this.groupBox1.Controls.Add(this.check_Rotate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_highFilter);
            this.groupBox1.Controls.Add(this.text_lowFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controladores do Gráfico";
            // 
            // slider_low
            // 
            this.slider_low.Location = new System.Drawing.Point(18, 70);
            this.slider_low.Maximum = 30;
            this.slider_low.Name = "slider_low";
            this.slider_low.Size = new System.Drawing.Size(151, 45);
            this.slider_low.TabIndex = 12;
            this.slider_low.Scroll += new System.EventHandler(this.slider_low_Scroll);
            // 
            // slider_high
            // 
            this.slider_high.Location = new System.Drawing.Point(18, 165);
            this.slider_high.Maximum = 30;
            this.slider_high.Name = "slider_high";
            this.slider_high.Size = new System.Drawing.Size(151, 45);
            this.slider_high.TabIndex = 12;
            this.slider_high.Scroll += new System.EventHandler(this.slider_high_Scroll);
            // 
            // check_Rotate
            // 
            this.check_Rotate.AutoSize = true;
            this.check_Rotate.Location = new System.Drawing.Point(18, 227);
            this.check_Rotate.Name = "check_Rotate";
            this.check_Rotate.Size = new System.Drawing.Size(113, 17);
            this.check_Rotate.TabIndex = 9;
            this.check_Rotate.Text = "Rotacionar gráfico";
            this.check_Rotate.UseVisualStyleBackColor = true;
            this.check_Rotate.Visible = false;
            this.check_Rotate.CheckedChanged += new System.EventHandler(this.check_Transpose_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "High pass filter cutoff (Hz)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low pass filter cutoff (Hz)";
            // 
            // text_highFilter
            // 
            this.text_highFilter.Location = new System.Drawing.Point(18, 139);
            this.text_highFilter.Name = "text_highFilter";
            this.text_highFilter.Size = new System.Drawing.Size(151, 20);
            this.text_highFilter.TabIndex = 1;
            this.text_highFilter.TextChanged += new System.EventHandler(this.text_highFilter_TextChanged);
            // 
            // text_lowFilter
            // 
            this.text_lowFilter.Location = new System.Drawing.Point(18, 44);
            this.text_lowFilter.Name = "text_lowFilter";
            this.text_lowFilter.Size = new System.Drawing.Size(151, 20);
            this.text_lowFilter.TabIndex = 0;
            this.text_lowFilter.TextChanged += new System.EventHandler(this.text_lowFilter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sísmica Original";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(81, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Legenda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sísmica Filtrada";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lbl_amp_b);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbl_amp_a);
            this.groupBox3.Controls.Add(this.lbl_Tempo);
            this.groupBox3.Controls.Add(this.lbl_ms_high);
            this.groupBox3.Controls.Add(this.lbl_ms_low);
            this.groupBox3.Controls.Add(this.chart);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(238, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 497);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot Principal";
            // 
            // lbl_amp_b
            // 
            this.lbl_amp_b.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_amp_b.AutoSize = true;
            this.lbl_amp_b.Location = new System.Drawing.Point(279, 469);
            this.lbl_amp_b.Name = "lbl_amp_b";
            this.lbl_amp_b.Size = new System.Drawing.Size(13, 13);
            this.lbl_amp_b.TabIndex = 11;
            this.lbl_amp_b.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Amplitude";
            // 
            // lbl_amp_a
            // 
            this.lbl_amp_a.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_amp_a.AutoSize = true;
            this.lbl_amp_a.Location = new System.Drawing.Point(78, 469);
            this.lbl_amp_a.Name = "lbl_amp_a";
            this.lbl_amp_a.Size = new System.Drawing.Size(13, 13);
            this.lbl_amp_a.TabIndex = 9;
            this.lbl_amp_a.Text = "0";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Location = new System.Drawing.Point(10, 268);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(62, 13);
            this.lbl_Tempo.TabIndex = 8;
            this.lbl_Tempo.Text = "Tempo (ms)";
            // 
            // lbl_ms_high
            // 
            this.lbl_ms_high.AutoSize = true;
            this.lbl_ms_high.Location = new System.Drawing.Point(41, 453);
            this.lbl_ms_high.Name = "lbl_ms_high";
            this.lbl_ms_high.Size = new System.Drawing.Size(31, 13);
            this.lbl_ms_high.TabIndex = 7;
            this.lbl_ms_high.Text = "3000";
            // 
            // lbl_ms_low
            // 
            this.lbl_ms_low.AutoSize = true;
            this.lbl_ms_low.Location = new System.Drawing.Point(44, 88);
            this.lbl_ms_low.Name = "lbl_ms_low";
            this.lbl_ms_low.Size = new System.Drawing.Size(31, 13);
            this.lbl_ms_low.TabIndex = 6;
            this.lbl_ms_low.Text = "2000";
            // 
            // FiltroWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FiltroWindow";
            this.Text = "LTrace Projeto Teste";
            this.Load += new System.EventHandler(this.FiltroWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_high)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mockDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoDeEntrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private Accord.Controls.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_highFilter;
        private System.Windows.Forms.TextBox text_lowFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_ms_low;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Label lbl_ms_high;
        private System.Windows.Forms.CheckBox check_Rotate;
        private System.Windows.Forms.Label lbl_amp_b;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_amp_a;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.TrackBar slider_low;
        private System.Windows.Forms.TrackBar slider_high;
    }
}

