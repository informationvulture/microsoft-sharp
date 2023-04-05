var LogMachine = new Logger();


class Logger
{
    public string GetLevel(string logMessage)
    {
        string splitMessage = logMessage.Split(" ");
        return splitMessage[0];
    }

    public string analyzeSeverity(string logMessage)
    {
        string dangerLevel = GetLevel(logMessage).ToLower();
        if (dangerLevel = "green")
        {
            return "SAFE!"
        }
        else if (dangerLevel = "yellow")
        {
            return "DANGER!"
        }
        else
        {
            return $"The danger level of {dangerLevel} doesn't make sense, check output."
        }
    }

    static main(string[] args)
    {
        Console.WriteLine("Please enter a severity level")
        string userInput = Console.ReadLine();
        if (String.IsNullOrEmpty(userInput))
        {
            userInput = "GREEN: 10X024RMDM14"
        }

        string operationsResult = LogMachine.analyzeSeverity(userInput);
        Console.WriteLine(operationsResult)

    }
}

