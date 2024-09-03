using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        /// <summary>
        /// Inclui um novo Beneficiario
        /// </summary>
        /// <param name="Beneficiario">Objeto de Beneficiario</param>
        public long Incluir(DML.Beneficiario Beneficiario)
        {
            DAL.DaoBeneficiario bnf = new DAL.DaoBeneficiario();
            return bnf.Incluir(Beneficiario);
        }

        /// <summary>
        /// Altera um Beneficiario
        /// </summary>
        /// <param name="Beneficiario">Objeto de Beneficiario</param>
        public void Alterar(DML.Beneficiario Beneficiario)
        {
            DAL.DaoBeneficiario bnf = new DAL.DaoBeneficiario();
            bnf.Alterar(Beneficiario);
        }

       

        /// <summary>
        /// Excluir o Beneficiario pelo id
        /// </summary>
        /// <param name="id">id do Beneficiario</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoBeneficiario bnf = new DAL.DaoBeneficiario();
            bnf.Excluir(id);
        }

        /// <summary>
        /// Lista os Beneficiarios
        /// </summary>
        public List<DML.Beneficiario> Listar(long idCliente)
        {
            DAL.DaoBeneficiario bnf = new DAL.DaoBeneficiario();
            return bnf.Listar(idCliente);
        }
       
    }
}

