using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacaoPSG2021
{
    public abstract class Cliente
    {
        private int codCliente;

        private DateTime dataInclusao;

        public int CodCliente
        {
            get { return this.codCliente; }
            set { this.codCliente = value; }
        }

        public DateTime DataInclusao
        {
            get { return this.dataInclusao; }
            set { this.dataInclusao = value; }
        }

        public Cliente()
        {

        }

        public Cliente(int codigoCliente, DateTime dataInclusao)
        {
            this.codCliente = codigoCliente;
            this.dataInclusao = dataInclusao;
        }
    }
}
