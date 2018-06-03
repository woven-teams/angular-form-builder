using System;
using System.Collections.Generic;
using FormBuilder.API.Models;
using FormBuilder.Data.Entities;
using NUnit.Framework;

namespace FormBuilder.Tests
{
    [TestFixture]
    public class APITests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestValidAPIConstructors()
        {
            var emptyResponse = new APIResponse();
            Assert.IsNull(emptyResponse.Result);
            Assert.IsEmpty(emptyResponse.Messages);

            var resultOnlyResponse = new APIResponse(new Form
            {
                Name = "Sample Form"
            });
            Assert.AreEqual("Sample Form", ((Form) resultOnlyResponse.Result).Name);
            Assert.IsTrue(resultOnlyResponse.IsSuccess);
            Assert.IsEmpty(resultOnlyResponse.Messages);
        }
    }
}