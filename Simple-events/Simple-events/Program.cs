using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Simple_events
{
    class Program
    {
        static void Main(string[] args)
        {            
                Observable observerble = new Observable();
                Observer observer = new Observer();
                observerble.SomethingHappened += observer.HandleEvent;

                observerble.DoSomething();
            }
    }
}
