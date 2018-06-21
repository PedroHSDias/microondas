using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOndasDigital.Interfaces;

namespace MicroOndasDigital.Modelos.Programas
{
    public class ProgramaVegetais : ProgramaGenerico, IDetalhavel
    {
        public override int Tempo { get; protected set; } = 300000;
        public override int Potencia { get; protected set; } = 5;
        public override char MarcaTempo { get; protected set; } = 'v';
        public override string TempoMostrador { get; protected set; } = "vegetais";
        public override string NomePrograma { get; protected set; } = "Vegetais";
        public override string InstrucaoPrograma { get; protected set; } = "Informe \"vegetais\" no painel para selecionar esse programa";
        public override string PotenciaPrograma { get; protected set; } = "5";

        protected override int ConverterTempo(string parametro)
        {
            if (this.EntradaTempoCompativel(parametro))
            {
                return this.Tempo;
            }
            else
            {
                throw new Exception("Definição de tempo invalido");
            }
        }

        public override bool EntradaTempoCompativel(string parametro)
        {
            return parametro.ToUpper().Contains(this.TempoMostrador.ToUpper()); ;
        }

        protected override int ConverterPotencia(object parametro)
        {
            return this.Potencia;
        }
    }
}
