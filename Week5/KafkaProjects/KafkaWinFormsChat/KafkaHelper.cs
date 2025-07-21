using Confluent.Kafka;
using System;
using System.Threading;
using System.Windows.Forms;

public class KafkaHelper
{
    public static async void SendMessage(string topic, string message)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
        using var producer = new ProducerBuilder<Null, string>(config).Build();
        await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
        producer.Flush(TimeSpan.FromSeconds(5));
    }

    public static void StartConsuming(string topic, ListBox listBox)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "winform-chat",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
        consumer.Subscribe(topic);

        new Thread(() =>
        {
            while (true)
            {
                var cr = consumer.Consume();
                listBox.Invoke((MethodInvoker)(() =>
                    listBox.Items.Add($"[{DateTime.Now:T}] {cr.Message.Value}")
                ));
            }
        })
        { IsBackground = true }.Start();
    }
}
