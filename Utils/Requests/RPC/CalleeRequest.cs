using TechWeek.Infra.CrossbarIo.Utils.Delegates;

namespace TechWeek.Infra.CrossbarIo.Utils.Requests.RPC
{
    public class CalleeRequest<TRetorno, TParametro>
    {
        public string NomeMetodo { get; set; }

        public ExecutarCallee<TRetorno, TParametro> Run { get; set; }
    }
}
