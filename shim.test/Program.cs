using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace shim.test
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class TargetClass
    {
        
        

        public DateTime DoSomething()
        {
            return new ShimClass().Now;
        }
    }

    public class ShimClass
    {
        public DateTime Now { get {return DateTime.Now; } }
    }

}
