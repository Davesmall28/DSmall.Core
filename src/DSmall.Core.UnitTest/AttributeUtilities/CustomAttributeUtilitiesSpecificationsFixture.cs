namespace DSmall.Core.UnitTest
{
    /// <summary>The custom attribute utilities specifications fixture.</summary>
    public class CustomAttributeUtilitiesSpecificationsFixture
    {
        /// <summary>Gets or sets the under test.</summary>
        public IAttributeUtilities UnderTest { get; set; }

        /// <summary>The perform test setup.</summary>
        public void PerformTestSetup()
        {
            UnderTest = new AttributeUtilities();
        }
    }
}