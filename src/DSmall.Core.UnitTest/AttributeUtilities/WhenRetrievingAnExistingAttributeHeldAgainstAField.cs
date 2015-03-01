namespace DSmall.Core.UnitTest
{
    using DSmall.UnitTest.Core;
    using NUnit.Framework;

    /// <summary>The when retrieving an existing attribute held against a field.</summary>
    [TestFixture]
    public class WhenRetrievingAnExistingAttributeHeldAgainstAField : SpecificationBase
    {
        private CustomAttributeUtilitiesSpecificationsFixture testFixture;

        private DummyAttribute result;

        /// <summary>The expected attribute should be returned.</summary>
        [Test]
        public void ExpectedAttributeShouldBeReturned()
        {
            Assert.IsInstanceOf(typeof(DummyAttribute), result);
        }

        /// <summary>The expected attribute should hold correct values.</summary>
        [Test]
        public void ExpectedAttributeShouldHoldCorrectValues()
        {
            Assert.AreEqual(10, result.DummyValue);
        }

        /// <summary>The because of.</summary>
        protected override void BecauseOf()
        {
            base.BecauseOf();
            result = testFixture.UnderTest.GetAttributeFor<DummyAttribute, DummyClass>(dummy => dummy.DummyStringField);
        }

        /// <summary>The context.</summary>
        protected override void Context()
        {
            base.Context();

            testFixture = new CustomAttributeUtilitiesSpecificationsFixture();
            testFixture.PerformTestSetup();
        }
    }
}
