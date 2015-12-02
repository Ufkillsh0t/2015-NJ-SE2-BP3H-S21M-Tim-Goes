using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2015_NJ_SE2_BP3H_OO_Programma.Classes;
using System.Collections.Generic;

namespace StelPosseSamenTest
{
    [TestClass]
    public class PietPosseSamenTest
    {
        [TestMethod]
        public void WegWijsPiet()
        {
            List<Piet> posse = new List<Piet>();
            posse.Add(new WegWijsPiet());
            Administratie admin = new Administratie();


            Assert.AreEqual(posse, admin.StelPosseSamen(admin.Provincies[1].Gemeentes[0], null));
        }
    }
}
