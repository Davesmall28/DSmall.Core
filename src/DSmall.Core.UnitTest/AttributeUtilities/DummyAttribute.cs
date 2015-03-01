namespace DSmall.Core.UnitTest
{
    using System;

    /// <summary>The dummy attribute.</summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.All)]
    public class DummyAttribute : Attribute
    {
        /// <summary>Initialises a new instance of the <see cref="DummyAttribute"/> class.</summary>
        /// <param name="dummyValue">The dummy value.</param>
        public DummyAttribute(int dummyValue)
        {
            DummyValue = dummyValue;
        }

        /// <summary>Gets or sets the dummy value.</summary>
        public int DummyValue { get; set; }
    }
}