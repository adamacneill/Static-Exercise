namespace StaticExercise
{
    public static class TempConverterHelpers
    {
        public static double FarenheitToCelcius(double farTemp)

        {
            // C = (F - 32) * 5 / 9;
            return (farTemp - 32) * 5 / 9;
        }
    }
}