using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class Producer
{
    public static async Task SendMessage(string topic, string message)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();
        await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });

        Console.WriteLine($"[Producer] Sent: {message}");
        producer.Flush(TimeSpan.FromSeconds(5));
    }
}
