using MicroOndasDigital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Modelos.Programas
{
    public class ProgramaPersonalizado : ProgramaGenerico
    {
        public override int Tempo { get; protected set; }
        public override char MarcaTempo { get; protected set; } = '.';
        public override int Potencia { get; protected set; } = 10;
        public override string TempoMostrador { get; protected set; } = "0:00";
        public override string NomePrograma { get; protected set; } = "Programa Personalizado";
        public override string InstrucaoPrograma { get; protected set; } = "No campo tempo/programa infome o tempo de aquecimento no formato m:ss e seleciona a potencia de 1 a 10";
        public override string TempoPrograma { get; } = "Personalizavel";
        public override string PotenciaPrograma { get; protected set; } = "Padrão 10 (personalizavel)";
        public int TempoMinimo { get; } = 1000;
        public int TempoMaximo { get; } = 120000;
        public override bool EntradaTempoCompativel(string parametro)
        {
            string[] parametros = parametro.Split(':');

            if (parametros.Length == 2)
            {
                if (int.TryParse(parametros[0], out int n1) && int.TryParse(parametros[1], out int n2))
                {
                    return true;
                }
            }
            return false;
        }
        protected override int ConverterTempo(string parametro)
        {
            int minutos = 0;
            int segundos = 1;

            string[] parametros = parametro.Split(':');
            minutos = int.Parse(parametros[0]) * 60;
            segundos = int.Parse(parametros[1]);

            return (minutos + segundos) * 1000;
        }
        protected override bool TempoValido()
        {
            return base.TempoValido() && (this.Tempo <= this.TempoMaximo && this.Tempo >= this.TempoMinimo);
        }
        public override void ValidaRequisitosParaTimer()
        {
            if (!this.TempoValido())
                throw new Exception("Tempo Invalido! Tempo deve estar entre 0:01 e 2:00");
            if (!this.PotenciaValido())
                throw new Exception("Potencia Definida Invalida! Potencia deve ser entre 1 e 10");
        }

        protected override int ConverterPotencia(object parametro=null)
        {
            if (parametro!=null) {
                try
                {
                    return Convert.ToInt32(parametro);
                }
                catch
                {
                    throw new Exception("Valor informado para potencia invalido");
                }
            }
            return this.Potencia;
        }
    }
}
