namespace Quantity_Measurement
{
    /// <summary>
    /// Main Class
    /// </summary>
    public class QuantityMeasurement
    {
        /// <CompareLengths>
        /// Comparing feet to inch.
        /// </CompareLengths>
        /// <param name="lengthInFeet">to get length in feet.</param>
        /// <param name="lengthInInch">to get length in incht.</param>
        /// <convert Result></returns>
        public bool CompareLengths(double lengthInFeet, double lengthInInch)
        {
            double convertResult = lengthInFeet * 12;
            return convertResult == lengthInInch;
        }
    }
}
