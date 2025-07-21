using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string topic = "chat-messages";

        Console.WriteLine("Kafka Console Chat");
        Console.WriteLine("------------------");
        Console.WriteLine("Type:");
        Console.WriteLine("  send <your message>  → to send a message");
        Console.WriteLine("  listen               → to listen for messages\n");

        Console.Write("Enter command: ");
        string input = Console.ReadLine();

        if (input.StartsWith("send "))
        {
            string message = input.Substring(5);
            await Producer.SendMessage(topic, message);
        }
        else if (input == "listen")
        {
            Consumer.StartConsuming(topic);
        }
        else
        {
            Console.WriteLine("Unknown command.");
        }
    }
}
