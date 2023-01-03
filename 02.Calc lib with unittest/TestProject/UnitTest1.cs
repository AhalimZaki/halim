using CalcClass;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        Calc calc = new Calc();
        int[] nums = new int[] { 1, 2, 5, 6, 3, 9 }; 

   
        [TestMethod]
        public void TestAverage()
        {
            //Arrange


            //Act
            var result = calc.Average(nums);

            //Assert

            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void TestLargest()
        {

            //Act
            var result = calc.Largest(nums);

            //Assert

            Assert.IsTrue(result == 9);
        }

        [TestMethod]
        public void TestSmallest()
        {


            //Act
            var result = calc.Smallest(nums);

            //Assert

            Assert.IsTrue(result == 1);
        }
    }
}
