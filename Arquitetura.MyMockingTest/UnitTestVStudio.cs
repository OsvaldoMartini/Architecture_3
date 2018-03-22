using Arquitetura.MongoDB;
using Arquitetura.MyMocking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using Rhino.Mocks;

namespace Arquitetura.MyMockingTest
{
    [TestClass]
    public class UnitTestVStudio
    {


        //TDD -Test-Driven Development

        //When I first heard about TDD, the idea seemed to be pretty simple. Just by doing a little word swizzling, 
        //obviously TDD is when you have tests that drive your software development.

        //If we were to unpack the definition of TDD a bit more, we’d see that it is usually broken up into five different stages:

        //1) First the developer writes some tests.
        //2) The developer then runs those tests and (obviously) they fail because none of those features are actually implemented.
        //3) Next the developer actually implements those tests in code.
        //4) If the developer writes his code well, then the in next stage he will see his tests pass.
        //5) The developer can then refactor his code, add comments, clean it up, as he wishes because the developer knows that if the new code breaks something, 
        //   then the tests will alert him by failing.


        [TestMethod]
        [Priority(1)]
        public void SeeIfProperty_1_Called_Isolated()
        {
            //Cpntrolling the behavior

            //Skip over some proper method
            //Isolate framework does
            //The Isolate ThirdParty code
            //Isolate our code that wanna test
            //The ThirdParty object that we have no control
            //we testing wether our code called the aprorprieted function that they suposed calls
            //and is that we are using mocking for
            //we can call more then one functions
            //could called more then one functions per once
            var myMock = MockRepository.GenerateMock<IRealComplexyApi>();

            MyClassToTest myClass = new MyClassToTest(myMock);

            myMock.Expect(m => m.CallMe1());

            myClass.DoSomethingReallyImportant("1");

            //Assertions for Mocking
            myMock.VerifyAllExpectations();

            //Mocks vs Stub
            //Stub insurance the tests goes smudly and we verify we do assertions against ours class under tests
            //with the Mocks is different, we do assertions on the mock itself to verify did ours class did interactions 
            //that we expect to do hands to sort off interaction testing tittle we gave to this type of test

        }

        [TestMethod]
        [Priority(0)]
        public void SeeIfProperty_1_Called_Not_Isolated()
        {
            //Controlling the behavior

            //Dont Skip over some proper method
            //Not Isolate framework  (Dont skip the method)
            var myMock = MockRepository.GenerateMock<RealComplexyApi>();

            MyClassToTest myClass = new MyClassToTest(myMock);

            //myMock.Expect(m => m.CallMe1());

            myClass.DoSomethingReallyImportant("1");

            myMock.VerifyAllExpectations();

        }

        [TestMethod]
        public void InsertMockCaixaAzul()
        {
            System.Diagnostics.Debug.WriteLine("Testing Inser Mock");
            int numCaixa = 16;
            string cnpjProvider = "11111111111111";
            // Get user collection reference
            var caixaAzulDb = MongoWrapper.GetDatabase().GetCollection("caixaAzul");

            // Create BsonDocument object for new user
            var caixaAzul = new BsonDocument();
            caixaAzul["numeroCaixa"] = numCaixa;
            caixaAzul["cnpjCD"] = cnpjProvider;
            // Insert new user object to collection
            caixaAzulDb.Insert(caixaAzul);


        }


        [TestMethod]
        public void InsertMockCaixaAzul_2()
        {
            System.Diagnostics.Debug.WriteLine("Testing Inser Mock");
            int numCaixa = 17;
            string cnpjProvider = "22222222222222";
            // Get user collection reference
            var caixaAzulDb = MongoWrapper.GetDatabase().GetCollection("caixaAzul");

            // Create BsonDocument object for new user
            var caixaAzul = new BsonDocument();
            caixaAzul["numeroCaixa"] = numCaixa;
            caixaAzul["cnpjCD"] = cnpjProvider;
            // Insert new user object to collection
            caixaAzulDb.Insert(caixaAzul);


        }

        [TestMethod]
        public void InsertMockCaixaAzul_33333333333333()
        {
            System.Diagnostics.Debug.WriteLine("Testing Inser Mock");
            int numCaixa = 18;
            string cnpjProvider = "33333333333333";
            // Get user collection reference
            var caixaAzulDb = MongoWrapper.GetDatabase().GetCollection("caixaAzul");

            // Create BsonDocument object for new user
            var caixaAzul = new BsonDocument();
            caixaAzul["numeroCaixa"] = numCaixa;
            caixaAzul["cnpjCD"] = cnpjProvider;
            // Insert new user object to collection
            caixaAzulDb.Insert(caixaAzul);


        }




    }
}
