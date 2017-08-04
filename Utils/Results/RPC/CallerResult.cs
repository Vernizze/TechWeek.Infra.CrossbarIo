using TechWeek.Infra.CrossbarIo.Utils.Delegates;

namespace TechWeek.Infra.CrossbarIo.Utils.Results.RPC
{
    public class CallerResult<TRetorno, TParametro>
    {
        public string NomeMetodo { get; set; }

        public TParametro Parametros { get; set; }

        public ResultCaller<TRetorno> Resultado { get; set; }
    }
}
