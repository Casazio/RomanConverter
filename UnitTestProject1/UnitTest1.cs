using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1(){
            Assert.AreEqual("XIII",Converter.ToRoman(13));
        }

        [TestMethod]
        public void TestMethod2(){
            Assert.AreEqual("XII", Converter.ToRoman(12));
        }

        [TestMethod]
        public void TestMethod3() {
            Assert.AreEqual("XVI", Converter.ToRoman(16));
        }

        [TestMethod]
        public void TestMethod4() {
            Assert.AreEqual("CXLV", Converter.ToRoman(145));
        }

        [TestMethod]
        public void TestMethod5() {
            Assert.AreEqual("DLXXXVII", Converter.ToRoman(587));
        }

        [TestMethod]
        public void TestMethod6() {
            Assert.AreEqual("MMMCCLVII", Converter.ToRoman(3257));
        }

        [TestMethod]
        public void TestMethod7(){
            Assert.AreEqual("CCCXXXII", Converter.ToRoman(332));
        }

        [TestMethod]
        public void TestMethod8() {
            Assert.AreEqual("MMMCMXCIX", Converter.ToRoman(3999));
        }

        [TestMethod]
        public void TestMethod9() {
            Assert.AreEqual("I", Converter.ToRoman(1));
        }
    }
}