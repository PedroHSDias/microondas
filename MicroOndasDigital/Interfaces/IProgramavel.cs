using MicroOndasDigital.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndasDigital.Interfaces
{
    public interface IProgramavel
    {
        int Tempo { get; }
        string TempoMostrador { get; }
        void DefineTempo(string parametro);
        int Potencia { get; }
        void DefinePotencia(int potencia);
        void ValidaRequisitosParaTimer();
               
    }
}
