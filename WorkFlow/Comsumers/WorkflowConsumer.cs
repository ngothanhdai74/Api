using EasyNetQ;
using EasyNetQ.AutoSubscribe;
using WorkFlow.Models.Messages;

namespace WorkFlow.Comsumers
{
    public class WorkflowConsumer : IConsumeAsync<WorkflowModel>
    {
        public async Task ConsumeAsync(WorkflowModel message, CancellationToken cancellationToken = default)
        {
        }
    }
}
