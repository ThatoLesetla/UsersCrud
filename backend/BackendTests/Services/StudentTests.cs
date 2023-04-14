using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Interfaces;
using AutoMapper;
using Moq;

namespace Backend.Tests
{
    [TestClass()]
    public class StudentTests
    {
        private IRepositoryManager repositoryManager;
        private IMapper mapper;
        private ILoggerManager loggerManager;

        [TestInitialize]
        public void TestInitialize()
        {
            // set test dependencies
            repositoryManager = new Mock<IRepositoryManager>
        }

        [TestMethod()]
        public void CreateStudentTest()
        {
            Assert.Fail();
        }
    }
}