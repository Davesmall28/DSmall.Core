namespace Springboard365.Core.UnitTest
{
    using System;

    [Serializable]
    [AttributeUsage(AttributeTargets.All)]
    public class DummyAttribute : Attribute
    {
        public DummyAttribute(int dummyValue)
        {
            DummyValue = dummyValue;
        }

        public int DummyValue { get; set; }
    }
}