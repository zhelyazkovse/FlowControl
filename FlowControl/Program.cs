namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        // The main method is the entry point of the program. It shows the menu and handles user input.
        {
            bool isRunning = true;
            while (isRunning)
            {
                MenuHelper.ShowMenu();
                string userInput = Console.ReadLine();
                isRunning = MenuHelper.HandleInput(userInput);

                
            }
        }
    }
}
