using Confluent.Kafka;
using System;

class Consumer
{
    public static void StartConsuming(string topic)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "console-chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(topic);

        Console.WriteLine("[Consumer] Listening for messages...\n");

        while (true)
        {
            try
            {
                var cr = consumer.Consume();
                Console.WriteLine($"[Consumer] Received: {cr.Message.Value}");
            }
            catch (ConsumeException ex)
            {
                Console.WriteLine($"[Consumer Error] {ex.Message}");
            }
        }
    }
}
