namespace Springboard365.Core.UnitTest
{
    using System;

    public class DummyClass
    {
        [Dummy(10)]
        public string DummyStringField { get; set; }

        [Dummy(20)]
        public int DummyIntegerField { get; set; }

        public DateTime NoAttributeSetOnThis { get; set; }
    }
}