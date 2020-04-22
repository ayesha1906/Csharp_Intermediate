using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowobj = new Workflow();
            workFlowobj.Add(new VideoUploader());
            workFlowobj.Add(new CallWebService());
            workFlowobj.Add(new SendEmail());
            workFlowobj.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlowobj);

        }
    }

}
