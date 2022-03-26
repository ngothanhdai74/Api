
using EasyNetQ;

namespace WorkFlow.Models.Messages
{
    [Queue(nameof(WorkflowModel))]
    public class WorkflowModel
    {

    }
}
