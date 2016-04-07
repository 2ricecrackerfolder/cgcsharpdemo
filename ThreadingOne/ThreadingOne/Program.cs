using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingOne
{
    class Program
    {
        static void Main(string[] args)
        { 
            Log("Started Main");
            var cts = new CancellationTokenSource();
            ThreadPool.QueueUserWorkItem(obj => ComputeBoundOp(cts.Token));
            Console.WriteLine("Press any key to cancel");
            Console.ReadKey();
            cts.Cancel();
            //Log("Started other work on main");
            //Thread.Sleep(2000);
            //Log("Finished other work on main");
            Log("Finished Main");
            Console.ReadKey();
        }

        static void Log(string msg)
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + msg);
        }

        static void ComputeBoundOp(CancellationToken token)
        {
            Log("Started ComputeBoundOp");
            for (int i = 0; i < 5; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Log("ComputeBoundOp cancelled");
                    break;
                }
                Thread.Sleep(1000);
                Log("ComputeBoundOp (" + i + ")");
            }
            Log("Finished ComputeBoundOp");
        }
    }
}
