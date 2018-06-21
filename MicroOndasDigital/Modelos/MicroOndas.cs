using MicroOndasDigital.Interfaces;
using MicroOndasDigital.Modelos.Programas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroOndasDigital.Modelos
{
    public class MicroOndas
    {
        public ProgramaGenerico ProgramaSelecionado { get; private set; }
        private IList<ProgramaGenerico> programas = new List<ProgramaGenerico>();
        private Timer contador;
        private int tempoPrograma;
        private Button botaoIniciar;
        private Button botaoCancelar;
        private TextBox textBoxExibeTempo;
        private NumericUpDown selectPotencia;
        public MicroOndas(Button inicio, Button pausaCancela, TextBox exibeTempo, NumericUpDown potencia)
        {
            this.botaoIniciar = inicio;
            this.botaoCancelar = pausaCancela;
            this.botaoCancelar.Enabled = false;
            this.textBoxExibeTempo = exibeTempo;
            this.selectPotencia = potencia;
            this.textBoxExibeTempo.Text = "";
            this.selectPotencia.Value = 10;

            programas.Add(new ProgramaPersonalizado());
            programas.Add(new ProgramaRapido());
            programas.Add(new ProgramaCarnes());
            programas.Add(new ProgramaMassas());
            programas.Add(new ProgramaPeixes());
            programas.Add(new ProgramaPipoca());
            programas.Add(new ProgramaVegetais());
        }
        private string ConverteTempoMilisegundosParaTimer()
        {
            int minutos = this.ProgramaSelecionado.Tempo / 60000;
            int segundos = (this.ProgramaSelecionado.Tempo - (int)(minutos * 60000)) / 1000;
            return $"{minutos}:{segundos}";
        }
        private string ConverteTempoMilisegundosParaTimer(int tempo)
        {
            int minutos = tempo / 60000;
            int segundos = (tempo - (int)(minutos * 60000)) / 1000;
            return $"{minutos}:{segundos}";
        }
        public void EscolhePrograma(int indice)
        {
            if (contador == null)
            {
                this.ProgramaSelecionado = programas[indice];
            }
        }
        public void EscolhePrograma(string tempo, int potencia)
        {
            if (contador == null)
            {
                this.ProgramaSelecionado = ProgramaBuilder.GetPrograma(this.programas, tempo);
                this.ProgramaSelecionado.DefineTempo(tempo);
                this.ProgramaSelecionado.DefinePotencia(potencia);
            }
        }
        public string DescricaoProgramaSelecionado()
        {
            return $"Programa: {this.ProgramaSelecionado.NomePrograma}{Environment.NewLine}{Environment.NewLine}" +
                $"Instruções: {this.ProgramaSelecionado.InstrucaoPrograma}{Environment.NewLine}{Environment.NewLine}" +
                $"Potencia: {this.ProgramaSelecionado.PotenciaPrograma}{Environment.NewLine}{Environment.NewLine}" +
                $"Tempo: {this.ProgramaSelecionado.TempoPrograma}{Environment.NewLine}{Environment.NewLine}";
        }
        public IList<IDetalhavel> DetalhesProgramas()
        {
            return programas.Select(p => p as IDetalhavel).ToList();
        }


        public void IniciarContinuarCozinhar()
        {
            if (contador == null)
            {
                this.contador = new Timer();
                this.ProgramaSelecionado.ValidaRequisitosParaTimer();
            }
            if (this.tempoPrograma == 0)
            {
                this.tempoPrograma = this.ProgramaSelecionado.Tempo;
            }
            contador.Tick += new EventHandler(this.EventoAlteraTimer);
            contador.Interval = 1000;
            contador.Start();
            this.selectPotencia.Value = this.ProgramaSelecionado.Potencia;
            this.botaoCancelar.Enabled = true;
            this.botaoCancelar.Text = "Pausar";
            this.botaoIniciar.Enabled = false;
        }

        public void PausarCancelarCozimento()
        {
            if (contador.Enabled)
            {
                this.contador.Stop();
                this.botaoIniciar.Text = "Continuar";
                this.botaoCancelar.Text = "Cancelar";
                this.botaoIniciar.Enabled = false;
                this.botaoIniciar.Enabled = true;
                this.textBoxExibeTempo.Text = $"{this.ConverteTempoMilisegundosParaTimer(this.tempoPrograma)} pausado";
            }
            else
            {
                this.FinalizarCozimento(false);
            }
        }

        private void EventoAlteraTimer(Object myObject, EventArgs myEventArgs)
        {
            int repeticoes = (this.ProgramaSelecionado.Potencia * ((this.ProgramaSelecionado.Tempo - this.tempoPrograma) / 1000));
            string rastro = new String(this.ProgramaSelecionado.MarcaTempo, repeticoes);
            if (this.tempoPrograma >= 0)
            {
                rastro += this.ProgramaSelecionado.GeraMarcaTempo();
                this.textBoxExibeTempo.Text = this.ConverteTempoMilisegundosParaTimer(this.tempoPrograma) + rastro;
                this.tempoPrograma -= contador.Interval;

            }
            else
            {
                this.FinalizarCozimento(true);
            }
        }
        public void FinalizarCozimento(bool naturalmente)
        {
            if (naturalmente)
            {
                this.textBoxExibeTempo.Text = "aquecida";
            }
            else
            {
                this.textBoxExibeTempo.Text = "Aquecimento cancelado";
            }
            this.tempoPrograma = 0;
            this.contador.Stop();
            this.contador = null;
            this.botaoCancelar.Enabled = false;
            this.botaoCancelar.Text = "Pausar/Cancelar";
            this.botaoIniciar.Enabled = true;
            this.botaoIniciar.Text = "Iniciar";
        }
    }
}
