using NPOI.SS.Formula.Functions;
using System.Diagnostics;
using System.Reflection;

namespace sga_stif.Helper
{
    public class ResultadoMetodo<T>
    {
        /// <summary>
        /// True caso a chamada foi efectuada com sucesso e falso caso não
        /// </summary>
        public bool Sucesso { get; set; }
        /// <summary>
        /// Mensagem discrevendo o resultado da chamada
        /// </summary>
        public string Mensagem { get; set; } = string.Empty;

        /// <summary>
        /// Dados da chamada caso é necessario
        /// </summary>
        public T Dados { get; set; }

        public ResultadoMetodo()
        {

        }

        /// <summary>
        /// Tipo de retorno em caso de exception
        /// </summary>
        /// <param name="e"></param>
        public ResultadoMetodo(Exception e)
        {
            Dados = default(T);
            Sucesso = false;
            Mensagem = e.Message;
        }

        /// <summary>
        /// Tipo de retorno em caso do erro conhecido
        /// </summary>
        /// <param name="mensagem"></param>
        public ResultadoMetodo(string mensagem)
        {
            Dados = default(T);
            Sucesso = false;
            Mensagem = mensagem;
        }
        /// <summary>
        /// Tipo de retorno em caso de sucesso
        /// </summary>
        /// <param name="dados"></param>
        /// <param name="mensagem"></param>

        public ResultadoMetodo(T dados, string mensagem = "Sucesso!")
        {
            Dados = dados;
            Sucesso = true;
            Mensagem = mensagem;
        }
    }
}
