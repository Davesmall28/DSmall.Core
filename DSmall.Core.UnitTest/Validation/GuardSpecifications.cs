namespace DSmall.Core.UnitTest
{
    using System;
    using DSmall.UnitTest.Core;
    using NUnit.Framework;
    using Guard = DSmall.Core.Guard;

    // ReSharper disable ExpressionIsAlwaysNull

    /// <summary>The guard specifications.</summary>
    [TestFixture]
    public class GuardSpecifications : SpecificationBase
    {
        /// <summary>The null check should execute successfully.</summary>
        [Test]
        public void NullCheckShouldExecuteSuccessfully()
        {
            DummyClass toTest = new DummyClass();
            Guard.NotNull(() => toTest, toTest);
        }

        /// <summary>The should throw argument null exception.</summary>
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullException()
        {
            DummyClass toTest = null;
            Guard.NotNull(() => toTest, toTest);
        }

        /// <summary>The null or empty check should execute successfully.</summary>
        [Test]
        public void NullOrEmptyCheckShouldExecuteSuccessfully()
        {
            const string ToTest = "testString";
            Guard.NotNullOrEmpty(() => ToTest, ToTest);
        }

        /// <summary>The should throw argument exception.</summary>
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentException()
        {
            string toTest = string.Empty;
            Guard.NotNullOrEmpty(() => toTest, toTest);
        }
    }
}
