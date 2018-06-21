using MicroOndasDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndasDigital.Modelos.Programas
{
    public abstract class ProgramaGenerico : IAlteraTela, IDetalhavel, IListaProgramas
    {
        public abstract int Tempo { get; protected set; }
        public abstract int Potencia { get; protected set; }
        public abstract char MarcaTempo { get; protected set; }
        public abstract string TempoMostrador { get; protected set; }
        public ProgramaGenerico ProximoPrograma { get; set; }
        public abstract string NomePrograma { get; protected set; }
        public abstract string InstrucaoPrograma { get; protected set; }
        public virtual string TempoPrograma
        {
            get
            {
                int minutos = this.Tempo / 60000;
                int segundos = (this.Tempo - (int)(minutos * 60000))/1000;
                return $"{minutos}:{segundos}";
            }
        }
        public abstract string PotenciaPrograma { get; protected set; }
        public abstract bool EntradaTempoCompativel(string parametro);
        protected abstract int ConverterTempo(string parametro);
        protected abstract int ConverterPotencia(object parametro);



        public ProgramaGenerico EscolhePrograma(string parametro)
        {
            if (this.EntradaTempoCompativel(parametro))
            {
                return this;
            }
            else
            {
                if (this.ProximoPrograma == null)
                    throw new Exception("Nenhum programa definido");
                else
                    return this.ProximoPrograma.EscolhePrograma(parametro);
            }
        }

        public void DefineTempo(string parametro)
        {
            if (this.EntradaTempoCompativel(parametro))
            {
                this.Tempo = this.ConverterTempo(parametro);
            }

        }
        public void DefinePotencia(int potencia)
        {
            this.Potencia = this.ConverterPotencia(potencia);
        }

        protected virtual bool TempoValido()
        {
            if (this.Tempo == 0)
            {
                throw new Exception("Tempo de cozimento não definido");
            }
            else if (this.Tempo < 0)
            {
                throw new Exception("Tempo de cozimento invalido");
            }
            else
            {
                return true;
            }
        }
        protected bool PotenciaValido()
        {
            return (this.Potencia >= 1 && this.Potencia <= 10);
        }
        public virtual void ValidaRequisitosParaTimer()
        {
            if (!this.TempoValido())
                throw new Exception("Tempo Invalido! Tempo deve um ser maior que 1  no formato 0:01");
            if (!this.PotenciaValido())
                throw new Exception("Potencia Definida Invalida! Potencia deve ser entre 1 e 10");
        }
        public string GeraMarcaTempo()
        {
            return new String(this.MarcaTempo, this.Potencia);
        }

    }
}
