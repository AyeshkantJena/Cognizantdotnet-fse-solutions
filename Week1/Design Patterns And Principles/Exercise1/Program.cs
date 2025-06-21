using System;

// Singleton Logger class
public class Logger
{
    // Step 2: Private static instance (holds the one and only Logger)
    private static Logger instance;

    // Step 2: Private constructor prevents instantiation from outside
    private Logger()
    {
        Console.WriteLine("Logger Initialized");
    }

    // Step 2: Public static method to get the singleton instance
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger(); // Lazy initialization
        }
        return instance;
    }

    // Method to simulate logging
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

// Test class to verify singleton behavior
class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First message");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second message");

        if (logger1 == logger2)
        {
            Console.WriteLine("Singleton confirmed: Only one instance of Logger is used.");
        }
        else
        {
            Console.WriteLine("Singleton failed: Different instances found.");
        }
    }
}
