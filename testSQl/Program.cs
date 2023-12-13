using testSQl.Controllers;
using testSQl.Interfaces;
using testSQl.Services;

namespace testSQl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceStandardMessages.HelloMessages();

            string articleSP = Console.ReadLine();

            IWindowsController controller = new WindowsController();

            controller.GetWindowsByArticleSP(articleSP);
        }
    }
}
