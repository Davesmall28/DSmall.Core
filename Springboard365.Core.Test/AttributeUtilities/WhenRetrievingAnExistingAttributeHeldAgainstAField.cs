namespace Springboard365.Core.UnitTest
{
    using Springboard365.UnitTest.Core;
    using NUnit.Framework;

    [TestFixture]
    public class WhenRetrievingAnExistingAttributeHeldAgainstAField : SpecificationBase
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
            result = testFixture.UnderTest.GetAttributeFor<DummyAttribute, DummyClass>(dummy => dummy.DummyStringField);
        }

        [Test]
        public void ExpectedAttributeShouldBeReturned()
        {
            Assert.IsInstanceOf(typeof(DummyAttribute), result);
        }

        [Test]
        public void ExpectedAttributeShouldHoldCorrectValues()
        {
            Assert.AreEqual(10, result.DummyValue);
        }
    }
}
