
using EasyNetQ;

namespace WorkFlow.Models.Messages
{
    [Queue("TestMessagesQueue", ExchangeName = "MyTestExchange")]
    public class WorkflowModel
    {

    }
}
