using Core.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using System.Threading.Tasks;

namespace Vocabulary.Test.Persistence
{
    [TestClass]
    public class PersistenceQueryTest
    {

        [ClassInitialize()]
        public static async Task InitializeTestClass(TestContext testContext)
        {
            using IUnitOfWork uow = new UnitOfWork();
            await uow.FillDbAsync();
        }

        [TestMethod]
        public void U01_Test_UnitOfWork_FillDb_NumberOfDbSets()
        {
            using IUnitOfWork uow = new UnitOfWork();
            int targetNumber = 820;
            int amountOfWords = uow.WordRepository.GetAll().Count;
            Assert.AreEqual(targetNumber,amountOfWords,"Amount of words is wrong.");
        }

        //[TestMethod]
        //public void 

    }
}
