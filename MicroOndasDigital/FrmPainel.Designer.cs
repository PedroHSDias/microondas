namespace MicroOndasDigital
{
    partial class FrmPainel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempo = new System.Windows.Forms.TextBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.inicioRapido = new System.Windows.Forms.Button();
            this.pausaPara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.potencia = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.textBoxInstrucoes = new System.Windows.Forms.TextBox();
            this.listBoxSelecionaPrograma = new System.Windows.Forms.ListBox();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potencia)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.Location = new System.Drawing.Point(3, 21);
            this.tempo.Multiline = true;
            this.tempo.Name = "tempo";
            this.tempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tempo.Size = new System.Drawing.Size(407, 58);
            this.tempo.TabIndex = 0;
            this.tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // iniciar
            // 
            this.iniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iniciar.Location = new System.Drawing.Point(3, 3);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(131, 51);
            this.iniciar.TabIndex = 2;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // inicioRapido
            // 
            this.inicioRapido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inicioRapido.Location = new System.Drawing.Point(140, 3);
            this.inicioRapido.Name = "inicioRapido";
            this.inicioRapido.Size = new System.Drawing.Size(131, 51);
            this.inicioRapido.TabIndex = 3;
            this.inicioRapido.Text = "Inicio Rapido";
            this.inicioRapido.UseVisualStyleBackColor = true;
            this.inicioRapido.Click += new System.EventHandler(this.inicioRapido_Click);
            // 
            // pausaPara
            // 
            this.pausaPara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pausaPara.Location = new System.Drawing.Point(277, 3);
            this.pausaPara.Name = "pausaPara";
            this.pausaPara.Size = new System.Drawing.Size(133, 51);
            this.pausaPara.TabIndex = 4;
            this.pausaPara.Text = "Pausar";
            this.pausaPara.UseVisualStyleBackColor = true;
            this.pausaPara.Click += new System.EventHandler(this.pausaPara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tempo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo / Programa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pausaPara, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.iniciar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inicioRapido, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 677);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 57);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // potencia
            // 
            this.potencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potencia.Location = new System.Drawing.Point(116, 3);
            this.potencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.potencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.potencia.Name = "potencia";
            this.potencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.potencia.Size = new System.Drawing.Size(89, 45);
            this.potencia.TabIndex = 9;
            this.potencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelPotencia);
            this.flowLayoutPanel1.Controls.Add(this.potencia);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(115, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 73);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotencia.Location = new System.Drawing.Point(3, 0);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(107, 29);
            this.labelPotencia.TabIndex = 10;
            this.labelPotencia.Text = "Potencia";
            // 
            // textBoxInstrucoes
            // 
            this.textBoxInstrucoes.Location = new System.Drawing.Point(192, 207);
            this.textBoxInstrucoes.Multiline = true;
            this.textBoxInstrucoes.Name = "textBoxInstrucoes";
            this.textBoxInstrucoes.ReadOnly = true;
            this.textBoxInstrucoes.Size = new System.Drawing.Size(233, 445);
            this.textBoxInstrucoes.TabIndex = 12;
            // 
            // listBoxSelecionPrograma
            // 
            this.listBoxSelecionaPrograma.FormattingEnabled = true;
            this.listBoxSelecionaPrograma.ItemHeight = 16;
            this.listBoxSelecionaPrograma.Location = new System.Drawing.Point(12, 207);
            this.listBoxSelecionaPrograma.Name = "listBoxSelecionPrograma";
            this.listBoxSelecionaPrograma.Size = new System.Drawing.Size(174, 228);
            this.listBoxSelecionaPrograma.TabIndex = 15;
            this.listBoxSelecionaPrograma.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecionPrograma_SelectedIndexChanged);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(266, 614);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(93, 23);
            this.buttonSelecionar.TabIndex = 16;
            this.buttonSelecionar.Text = "Selecionar";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // FrmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 746);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.listBoxSelecionaPrograma);
            this.Controls.Add(this.textBoxInstrucoes);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPainel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.potencia)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button inicioRapido;
        private System.Windows.Forms.Button pausaPara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown potencia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.TextBox textBoxInstrucoes;
        private System.Windows.Forms.ListBox listBoxSelecionaPrograma;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}