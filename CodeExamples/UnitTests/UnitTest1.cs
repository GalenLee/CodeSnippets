﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CompositeKeyTests
    {
        [TestMethod]
        public void Test1()
        { 
            var a = new CompositeKey<int, int>(1, 2);
            var b = a.Value1;
            Assert.AreEqual(1, a.Value1);
        }

        [TestMethod]
        public void TestStringToHAsh()
        {
            var a = HashRelated.Md5StringToHash("Joe");
            Assert.AreEqual(8, a);
        }
    }
}
