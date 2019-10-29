using NUnit.Framework;
using StarWars.Context;
using System;

namespace StarWars.Test
{
    public class PaginationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var pagination = new Pagination(30,10);

            Assert.AreEqual(3,pagination.MaxPage);
            Assert.AreEqual(1,pagination.MinPage);
            Assert.AreEqual(10,pagination.PageSize);
            Assert.AreEqual(30,pagination.TotalItems);
        }

        [Test]
        public void Test2()
        {
            var pagination = new Pagination(31, 10);

            Assert.AreEqual(4, pagination.MaxPage);
            Assert.AreEqual(1, pagination.MinPage);
            Assert.AreEqual(10, pagination.PageSize);
            Assert.AreEqual(31, pagination.TotalItems);
        }

        [Test]
        public void Test3()
        {
            void Delegate()
            {
                var p = new Pagination(1,0);
            }
            Assert.Throws<ArgumentOutOfRangeException>(Delegate);
        }

        [Test]
        public void Test4()
        {
            var pagination = new Pagination(31, 10);

            Assert.AreEqual(10, pagination.GetSkip(2));
        }
    }
}