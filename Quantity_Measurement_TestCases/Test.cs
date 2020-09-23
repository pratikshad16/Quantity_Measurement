namespace Quantity_Measurement_TestCases
{
    using NUnit.Framework;
    using Quantity_Measurement;

    /// <summary>
    /// Test Class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// setup method
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// test method 1 
        /// </summary>
        [Test]
        public void GivenLength_whenSame_shouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            double lengthInFeet = 1;
            double lengthInInch = 12;
            bool result = quantityMeasurement.CompareLengths(lengthInFeet, lengthInInch);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// test method 2 
        /// </summary>
        [Test]
        public void GivenLength_whenNotSame_shouldReturnFalse()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            double lengthInFeet = 1;
            double lengthInInch = 11;
            bool result = quantityMeasurement.CompareLengths(lengthInFeet, lengthInInch);
            Assert.IsFalse(result);
        }
    }
}