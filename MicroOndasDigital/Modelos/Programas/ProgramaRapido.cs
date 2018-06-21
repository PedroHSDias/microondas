using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOndasDigital.Interfaces;

namespace MicroOndasDigital.Modelos.Programas
{
    public class ProgramaRapido : ProgramaGenerico
    {
        public override int Tempo { get; protected set; } = 30000;
        public override int Potencia { get; protected set; } = 8;
        public override char MarcaTempo { get; protected set; } = 'r';
        public override string TempoMostrador { get; protected set; } = "rapido";
        public override string NomePrograma { get; protected set; } = "Rapido";
        public override string InstrucaoPrograma { get; protected set; } = "Clique no botão \"Inicio rapido\" ou escreva rapido no mostrador";
        public override string PotenciaPrograma { get; protected set; } = "8";
        public override bool EntradaTempoCompativel(string parametro)
        {
            return parametro.ToUpper().Contains(this.TempoMostrador.ToUpper()); ;
        }

        protected override int ConverterTempo(string parametro=null)
        {
            return this.Tempo;
        }

        protected override int ConverterPotencia(object parametro)
        {
            return this.Potencia;
        }
    }
}
