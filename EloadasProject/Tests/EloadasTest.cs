using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EloadasProject.Tests
{
    [TestFixture]
    public class EloadasTest
    {
        private Eloadas eloadas;

        [SetUp]
        public void TestInit()
        {
            eloadas = new Eloadas(5, 5);
        }

        [Test]
        public void KonstruktorTest1()
        {
            Assert.Throws<ArgumentException>(() => new Eloadas(0, 5));
        }

        [Test]
        public void KonstruktorTest2()
        {
            Assert.Throws<ArgumentException>(() => new Eloadas(5, 0));
        }

        [Test]
        public void KonstruktorTest3()
        {
            Assert.Throws<ArgumentException>(() => new Eloadas(0, 0));
        }

        [Test]
        public void LefoglalTest1()
        {
            Assert.AreEqual(true, eloadas.Lefoglal());
        }

        [Test]
        public void LefoglalTest2()
        {
            Megtoltes();
            Assert.IsFalse(eloadas.Lefoglal());
        }

        [Test]
        public void SzabadHelyekTest1()
        {
            Assert.AreEqual(25, eloadas.HelySzabad());
        }  

        [Test]
        public void SzabadHelyekEsLefoglalTest()
        {
            Megtoltes();
            Assert.IsFalse(eloadas.Lefoglal());
            Assert.Zero(eloadas.HelySzabad());
        }


        [Test]
        public void TeliTest1()
        {
            Megtoltes();
            Assert.IsTrue(eloadas.Full());
        }

        [Test]
        public void TeliTest2()
        {
            Assert.IsFalse(eloadas.Full());
        }

        [Test]
        public void FoglaltTest1()
        {
            Megtoltes();
            Assert.IsTrue(eloadas.Lefoglalva(1, 1));
        }

        [Test]
        public void FoglaltTest2()
        {
            Assert.Throws<ArgumentException>(() => eloadas.Lefoglalva(0, 1));
        }

        [Test]
        public void FoglaltTest3()
        {
            Assert.Throws<ArgumentException>(() => eloadas.Lefoglalva(1, 0));
        }

        [Test]
        public void FoglaltTest4()
        {
            Assert.Throws<ArgumentException>(() => eloadas.Lefoglalva(0, 0));
        }

        [Test]
        public void FoglaltTest5()
        {
            Assert.IsFalse(eloadas.Lefoglalva(3, 3));
        }

        private void Megtoltes()
        {
            while (!eloadas.Full())
            {
                eloadas.Lefoglal();
            }
        }
    }
}
