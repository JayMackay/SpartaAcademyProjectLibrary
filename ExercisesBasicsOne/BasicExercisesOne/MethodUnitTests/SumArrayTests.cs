using NUnit.Framework;
using BasicExercisesOne;

namespace MethodUnitTests
{
    public class SumArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenTheArrayIsPopulatedTheSumIsCorrect()
        {
            int[] nums = { 3, 7, 1, 2, 4 };
            var result = ExerciseMethods.SumArray(nums);
            Assert.AreEqual(17, result);
        }

        [Test]
        public void WhenTheArrayIsEmptyTheSumIsZero()
        {
            int[] nums = { };
            var result = ExerciseMethods.SumArray(nums);
            Assert.AreEqual(0, result);
        }
    }
}
