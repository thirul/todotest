using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetManage.Services.Tests
{
    [TestFixture]
    public class Test
    
    {
        [Test]
        public void FirstTest()
        {
            var products = GetProducts();
            Assert.AreEqual(true, true);
        }

    }
}
