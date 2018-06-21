using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Interfaces
{
    public interface IAlteraTela : IProgramavel
    {
        char MarcaTempo { get; }
        string GeraMarcaTempo();
    }
}
