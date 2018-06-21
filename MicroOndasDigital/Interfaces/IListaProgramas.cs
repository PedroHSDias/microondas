using MicroOndasDigital.Modelos.Programas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Interfaces
{
    public interface IListaProgramas
    {

        ProgramaGenerico ProximoPrograma { get; set; }
        ProgramaGenerico EscolhePrograma(string parametro);
    }
}
