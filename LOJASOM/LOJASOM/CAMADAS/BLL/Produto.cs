using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOJASOM.CAMADAS.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public List<MODEL.Produto> SelectById(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectById(id);
        }

        public List<MODEL.Produto> SelectByDescricao(string descricao)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByDescricao(descricao);
        }

        public List<MODEL.Produto> SelectByMarca(string marca)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByMarca(marca);
        }

        public void Insert(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.descricao != "")
                dalProd.Insert(produto);
        }

        public void Update(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.descricao != string.Empty)
                dalProd.Update(produto);
        }

        public void Delete(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (id > 0)
                dalProd.Delete(id);
        }
    }
}
