namespace DSmall.UnitTest.Core
{
    using NUnit.Framework;

    /// <summary>The specification base.</summary>
    public abstract class SpecificationBase
    {
        /// <summary>Gets or sets the test context.</summary>
        public TestContext TestContext { get; set; }

        /// <summary>The test initialize.</summary>
        [SetUp]
        public void TestInitialize()
        {
            Context();

            BecauseOf();
        }

        /// <summary>The test clean up.</summary>
        [TearDown]
        public void TestCleanup()
        {
            Cleanup();
        }

        /// <summary>The context.</summary>
        protected virtual void Context()
        {
        }

        /// <summary>The because of.</summary>
        protected virtual void BecauseOf()
        {
        }

        /// <summary>The clean up.</summary>
        protected virtual void Cleanup()
        {
        }
    }
}