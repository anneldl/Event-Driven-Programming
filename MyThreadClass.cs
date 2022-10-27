using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LopezBasicThreading
{
    public class MyThreadClass
    {
        public void Thread1()
        {
            
            for(int loopCount=0; loopCount < 6; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: "+ thread.Name + "="+ loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}
