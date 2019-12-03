using System;
using System.Collections.Generic;
using System.Text;

namespace trab_4_bimestre_exer_3
{
    public class fornecedor : IComparable<fornecedor>

    {
        public string nome { get; set; }

        public string cnpj { get; set; }

        public string rg { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string bairro { get; set; }

        public string codigo { get; set; }

        public string area { get; set; }

        public string definicao { get; set; }

        public string habitualidade { get; set; }

        public int CompareTo(fornecedor dado)
        {
            return this.nome.CompareTo(dado.nome);
        }

    }


}
