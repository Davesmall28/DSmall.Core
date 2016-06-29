namespace DSmall.Core.UnitTest
{
    using System;
    using DSmall.UnitTest.Core;
    using NUnit.Framework;

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
        public void ShouldThrowArgumentNullException()
        {
            DummyClass toTest = null;
            Assert.Throws<ArgumentNullException>(() => Guard.NotNull(() => toTest, toTest));
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
        public void ShouldThrowArgumentException()
        {
            string toTest = string.Empty;
            Assert.Throws<ArgumentException>(() => Guard.NotNullOrEmpty(() => toTest, toTest));
        }
    }
}
