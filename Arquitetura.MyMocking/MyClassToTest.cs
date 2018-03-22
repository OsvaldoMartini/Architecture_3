using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.MyMocking
{
    
    public class MyClassToTest
    {
        private IRealComplexyApi _api;
    
        public MyClassToTest(IRealComplexyApi  API)
        {
            _api = API;

        }
    

        public void DoSomethingReallyImportant(String whatToDo)
        {
            switch (whatToDo)
            {
                case "1":
                    _api.CallMe1();
                    break;
                case "2":
                    _api.CallMe2();
                    break;
                case "3":
                    _api.CallMe3();
                    break;
                case "4":
                    _api.CallMe4();
                    break;
            }


        }


    }

    
}
