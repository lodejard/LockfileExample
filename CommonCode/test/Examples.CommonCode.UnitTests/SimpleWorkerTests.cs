using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Examples.CommonCode.UnitTests
{
    [TestClass]
    public class SimpleWorkerTests
    {
        [TestMethod]
        public void DoWorkDoesWork()
        {
            var worker = new SimpleWorker();
            var data = worker.DoWork(GetRecords());
            Assert.IsTrue(data.Contains("One"));
        }

        public IEnumerable<string[]> GetRecords()
        {
            yield return new[] { "One", "Two" };
            yield return new[] { "Three", "Four" };
            yield return new[] { "Five", "Six" };
        }
    }
}
