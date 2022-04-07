namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                string accessToken = @"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJhdXRoZW5fc2VydmljZSIsImV4cCI6MTY0OTM3NTc5NiwianRpIjoiIiwiaWF0IjoxNjQ5MzQ2OTk2LCJzdWIiOiIwMDAxMDk5MTg1IiwiY3VzdG9keUlEIjoiMTA1QzA5OTE4NSIsImVtYWlsIjoibmdvdGhhbmhkYWk3NEBnbWFpbC5jb20iLCJyb2xlcyI6WyJjdXN0b21lciIsIkFwcGxpY2F0aW9uL0NBRkZFSU5FX0JFVEFfVVNFUl9DUkVNQSJdLCJzdGVwdXBfZXhwIjowLCJzb3RwX3NpZ24iOiIiLCJjbGllbnRfa2V5IjoiMlB3TUlVbmM5TUY1ME1id2ZhQWNRUVRUanZKYW9kMUsiLCJzZXNzaW9uSUQiOiI1NWIxYmJkOS0zMzEyLTRlYTQtOTc5YS05YzI5MDFkYWVhYTYiLCJhY2NvdW50X3N0YXR1cyI6IjEiLCJvdHAiOiIiLCJvdHBUeXBlIjoiIn0.VfWWm2TdryEvh0YOuuTCnitt1aG0IPtHQNty3NVooCMeeWjBA4utojo_0nmIMcZn62HHVCVWeVNHSUOkoDd4LfvrLN0AOla5jLd3QYDykFcbE39rRwMfxoNWNqaUujgSbp6nMSebuYhYRfAWOODkuiVKedPCc_8Ncz1IvaDysXxYmqtGcZ4jcO0Q5XkwcBpF5sFK7NJ7DgUZmO8k6Z_aDquQJg6P2QAorG1RySG5_d8qnVQA58hIKUl17y1RV-f10LywJ2Ma66EzrSxCmvJ3rW78zBBhm3IA9rgBBwsneyt-xkCzp2fotdtBaFY4jSid5RX4iBnZcrqay53ozUtpdA";


                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}