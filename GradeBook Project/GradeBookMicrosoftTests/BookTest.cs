using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gradebook;

namespace GradeBookMicrosoftTests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookCalculatesAnAverageGrade()
        {
            //arange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.AreEqual(85.6, result.Average, 1);
            Assert.AreEqual(90.5, result.High, 1);
            Assert.AreEqual(77.3, result.Low, 1);
            Assert.AreEqual('B', result.Letter);
        }
    }
}
