using TechWeek.Infra.CrossbarIo.Utils.Delegates;

namespace TechWeek.Infra.CrossbarIo.Utils.Results.PubSub
{
    public class SubContent<TMensagem>
    {
        public string NomeFila { get; set; }

        public GetMessage<TMensagem> MessageListener { get; set; }
    }
}
