namespace TelefonenUkazatel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string name = tokens[1];

                if (command == "A")
                {
                    string phoneNumber = tokens[2];
                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
