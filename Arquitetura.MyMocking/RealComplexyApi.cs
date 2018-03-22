using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.MyMocking
{
    public class RealComplexyApi : IRealComplexyApi
    {
        public void CallMe1()
        {
            //throw new Exception();
            System.Diagnostics.Debug.WriteLine("Methodo Called CLAUDIA = 1");
        }
        public void CallMe2()
        {
            System.Diagnostics.Debug.WriteLine("Methodo Called OSVALDO  = 2");
        }
        public void CallMe3()
        {
            System.Diagnostics.Debug.WriteLine("Methodo Called  = 3");
        }
        public void CallMe4()
        {
            System.Diagnostics.Debug.WriteLine("Methodo Called  = 4");
        }

    }
}
