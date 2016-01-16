using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace assert
{

    [TestFixture]
    class Sample
    {

        [Test]
        public void Test()
        {
            //var expected = 5;
            //var actual = 5; 
            //var startValue = 5;
            //var actual =115;
            //Assert.AreNotEqual(startValue, actual);
            //Assert.IsTrue(value);
           // string  value = null;
            //string value = string.Empty;
            //Assert.IsNull(value);
            //Assert.IsNotNull(value);

           // Assert.IsNullOrEmpty(value);


            //var numbers = new List<int> { 1, 2, 3, 4, 5 };
            //var actual = 5;
            //Assert.Contains(actual, numbers);


            //var expected = 5;
            //var actual = 5;
            //Assert.That(actual, Is.EqualTo(expected));

            //var actual = false;

            //Assert.That(actual, Is.False);

            var numbers = new List<int> { 6, 7, 8, 9};
            var actual = 6;
            Assert.That(numbers, Has.Member(actual));
        }





    }
}
