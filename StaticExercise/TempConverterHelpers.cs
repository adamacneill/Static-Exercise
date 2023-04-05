namespace StaticExercise
{
    internal static class TempConverterHelpers
    {
        public static double FarenheitToCelcius(double farTemp)
        {
            // C = (F - 32) * 5 / 9;
            var answer = (farTemp - 32) * 5 / 9;
        }
    }
}