﻿using MicroOndasDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Modelos.Programas
{
    public class ProgramaPipoca : ProgramaGenerico
    {
        public override int Tempo { get; protected set; } = 400000;
        public override int Potencia { get; protected set; } = 9;
        public override char MarcaTempo { get; protected set; } = 'P';
        public override string TempoMostrador { get; protected set; } = "pipoca";
        public override string NomePrograma { get; protected set; } = "Pipoca";
        public override string InstrucaoPrograma { get; protected set; } = "Informe \"pipoca\" no painel para selecionar esse programa";
        public override string PotenciaPrograma { get; protected set; } = "9";
        
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
