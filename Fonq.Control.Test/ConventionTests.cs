using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fonq.Control.Data;

namespace Font.Control.Test
{
    [TestClass]
    public class ConventionTests
    {
        [TestMethod]
        public void RenamesTwoWordProperty()
        {
            Assert.AreEqual("house_no", UnderscoreNamingStrategy.FromProperty("HouseNo"));
        }

        [TestMethod]
        public void RenamesThreeWordProperty()
        {
            Assert.AreEqual("house_no_suffix", UnderscoreNamingStrategy.FromProperty("HouseNoSuffix"));
        }
    }
}
