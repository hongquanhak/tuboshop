using Microsoft.VisualStudio.TestTools.UnitTesting;
using TuboShop.Data.Infrastructure;
using TuboShop.Data.Repositories;
using TuboShop.Model.Models;
using System.Linq;

namespace TuboShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
            public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod] //testcase
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory()
            {
                Name = "Test category", //thuoc tinh not null
                Alias = "Test-category",
                Status = true
            };

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }
    }
}