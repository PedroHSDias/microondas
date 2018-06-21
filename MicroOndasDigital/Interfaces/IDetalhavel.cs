using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Interfaces
{
    public interface IDetalhavel
    {
        string NomePrograma { get; }
        string InstrucaoPrograma { get; }
        string TempoPrograma { get; }
        string PotenciaPrograma { get; }
    }
}
