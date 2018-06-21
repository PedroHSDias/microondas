using MicroOndasDigital.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Modelos.Programas
{
    public static class ProgramaBuilder
    {
        public static ProgramaGenerico GetPrograma(IList<ProgramaGenerico> lista,  string tempo) {
            for (int i = 0; i < lista.Count; i++)
            {
                if (i+1<lista.Count) {
                    lista[i].ProximoPrograma = lista[i + 1];
                }
            }
            return lista[0].EscolhePrograma(tempo);
        }
    }
}
