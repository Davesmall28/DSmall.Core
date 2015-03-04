namespace DSmall.Core.UnitTest
{
    using DSmall.UnitTest.Core;
    using NUnit.Framework;

    /// <summary>The when attempting retrieval of an attribute that is not set on a field.</summary>
    [TestFixture]
    public class WhenAttemptingRetrievalOfAnAttributeThatIsNotSetOnAField : SpecificationBase
    {
        private CustomAttributeUtilitiesSpecificationsFixture testFixture;

        private DummyAttribute result;

        /// <summary>The expected attribute should be null.</summary>
        [Test]
        public void ExpectedAttributeShouldBeNull()
        {
            Assert.IsNull(result);
        }

        /// <summary>The because of.</summary>
        protected override void BecauseOf()
        {
            base.BecauseOf();
            result = testFixture.UnderTest.GetAttributeFor<DummyAttribute, DummyClass>(dummy => dummy.NoAttributeSetOnThis);
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
