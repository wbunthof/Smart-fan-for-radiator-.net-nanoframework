using System.Diagnostics;
using System.Threading;

namespace SmartFanController;

public class Program
{
    public static void Main()
    {
        Debug.WriteLine("Smart fan controller started.");
        Thread.Sleep(Timeout.Infinite);
    }
}
