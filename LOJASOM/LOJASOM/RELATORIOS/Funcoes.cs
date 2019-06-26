using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.RELATORIOS
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\RELLOJASOM";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }
    }
}
