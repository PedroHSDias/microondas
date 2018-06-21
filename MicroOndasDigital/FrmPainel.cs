using MicroOndasDigital.Interfaces;
using MicroOndasDigital.Modelos;
using MicroOndasDigital.Modelos.Programas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class FrmPainel : Form
    {
        private Timer contador = new Timer();
        private MicroOndas micro;

        public FrmPainel()
        {
            InitializeComponent();
        }


        private void Painel_Load(object sender, EventArgs e)
        {
            micro = new MicroOndas(this.iniciar, this.pausaPara, this.tempo, this.potencia);
            this.montaComboProgramas(micro.DetalhesProgramas(), this.listBoxSelecionaPrograma);
        }
        private void iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                this.micro.EscolhePrograma(tempo.Text, (int)potencia.Value);

                this.micro.IniciarContinuarCozinhar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Entrada invalida!");
            }
        }

        private void inicioRapido_Click(object sender, EventArgs e)
        {
            try
            {
                this.micro.EscolhePrograma("rapido", 0);
                this.micro.IniciarContinuarCozinhar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Entrada invalida!");
            }
        }

        private void pausaPara_Click(object sender, EventArgs e)
        {
            this.micro.PausarCancelarCozimento();
        }



        public void montaComboProgramas(IList<IDetalhavel> programas, ListBox combo)
        {
            foreach (IDetalhavel p in programas)
            {
                combo.Items.Add(p.NomePrograma);
            }
            combo.SelectedIndex = 0;
            this.ManipulaTimerPotenciaPadrao();
        }

        private void listBoxSelecionPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            micro.EscolhePrograma(this.listBoxSelecionaPrograma.SelectedIndex);
            this.ManipulaTimerPotenciaPadrao();
        }

        public void ManipulaTimerPotenciaPadrao()
        {
            this.textBoxInstrucoes.Text = this.micro.DescricaoProgramaSelecionado();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            this.potencia.Value = micro.ProgramaSelecionado.Potencia;
            this.tempo.Text = micro.ProgramaSelecionado.TempoMostrador;
        }
    }
}
