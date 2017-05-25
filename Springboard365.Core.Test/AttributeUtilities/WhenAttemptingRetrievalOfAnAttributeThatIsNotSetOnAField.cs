namespace Springboard365.Core.UnitTest
{
    using Springboard365.UnitTest.Core;
    using NUnit.Framework;

    [TestFixture]
    public class WhenAttemptingRetrievalOfAnAttributeThatIsNotSetOnAField : SpecificationBase
    {
        private CustomAttributeUtilitiesSpecificationsFixture testFixture;
        private DummyAttribute result;

        protected override void Context()
        {
            base.Context();
            testFixture = new CustomAttributeUtilitiesSpecificationsFixture();
            testFixture.PerformTestSetup();
        }

        protected override void BecauseOf()
        {
            base.BecauseOf();
            result = testFixture.UnderTest.GetAttributeFor<DummyAttribute, DummyClass>(dummy => dummy.NoAttributeSetOnThis);
        }

        [Test]
        public void ExpectedAttributeShouldBeNull()
        {
            Assert.IsNull(result);
        }
    }
}
