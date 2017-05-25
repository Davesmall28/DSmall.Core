namespace Springboard365.Core.UnitTest
{
    using System;
    using NUnit.Framework;
    using Springboard365.UnitTest.Core;
    using Guard = Springboard365.Core.Guard;

    // ReSharper disable ExpressionIsAlwaysNull

    [TestFixture]
    public class GuardSpecifications : SpecificationBase
    {
        [Test]
        public void NullCheckShouldExecuteSuccessfully()
        {
            var toTest = new DummyClass();
            Guard.NotNull(toTest);
        }

        [Test]
        public void ShouldThrowArgumentNullException()
        {
            DummyClass toTest = null;
            Assert.Throws<ArgumentNullException>(() => Guard.NotNull(toTest));
        }

        [Test]
        public void NullOrEmptyCheckShouldExecuteSuccessfully()
        {
            const string ToTest = "testString";
            Guard.NotNullOrEmpty(ToTest);
        }

        [Test]
        public void ShouldThrowArgumentException()
        {
            var toTest = string.Empty;
            Assert.Throws<ArgumentException>(() => Guard.NotNullOrEmpty(toTest));
        }
    }
}
