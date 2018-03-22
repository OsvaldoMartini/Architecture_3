using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using Arquitetura.MyMocking;

namespace Arquitetura.MyMockingTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void SeeIfProperty_1_Called()
        {
            //Cpntrolling the behavior
            var myMock = MockRepository.GenerateMock<IRealComplexyApi>();
            MyClassToTest myClass = new MyClassToTest(myMock);

            myMock.Expect(m => m.CallMe1());

            myClass.DoSomethingReallyImportant("1");

            myMock.VerifyAllExpectations();

        }
    }



}
