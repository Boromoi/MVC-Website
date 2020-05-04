using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gradebook;
using System;

namespace Gradebook.Tests
{
    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.AreEqual(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [TestMethod]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.AreEqual("Book 1", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [TestMethod]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.AreEqual("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [TestMethod]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.AreEqual("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [TestMethod]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Liam";
            var upper = MakeUpperCase(name);

            Assert.AreEqual("Liam", name);
            Assert.AreEqual("LIAM", upper);
        }

        private string MakeUpperCase(string paremeter)
        {
            return paremeter.ToUpper();
        }

        [TestMethod]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
            Assert.AreNotEqual(book1, book2);
        }

        [TestMethod]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.AreSame(book1, book2);
            Assert.IsTrue(object.ReferenceEquals(book1, book2));
        }


        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
