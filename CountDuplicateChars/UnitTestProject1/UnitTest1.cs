using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CountDuplicates
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOverallCount()
        {
            IEnumerable<KeyValuePair<string, int>> result = StringCount.GetCounts("aaAbBbCc1233*");
            Assert.AreEqual(4, result.Count());
        }
    }
}
