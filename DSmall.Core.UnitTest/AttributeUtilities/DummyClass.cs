namespace DSmall.Core.UnitTest
{
    using System;

    /// <summary>The dummy class.</summary>
    public class DummyClass
    {
        /// <summary>
        /// Gets or sets the dummy string field.
        /// </summary>
        [Dummy(10)]
        public string DummyStringField { get; set; }

        /// <summary>
        /// Gets or sets the dummy integer field.
        /// </summary>
        [Dummy(20)]
        public int DummyIntegerField { get; set; }

        /// <summary>
        /// Gets or sets the no attribute set on this.
        /// </summary>
        public DateTime NoAttributeSetOnThis { get; set; }
    }
}