using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.CAMADAS.MODEL
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public float quantidade { get; set; }
        public float preco { get; set; }
        public virtual float total { get { return quantidade * preco; } }
    }
}
