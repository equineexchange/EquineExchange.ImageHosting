namespace EquineExchange.ImageHosting
{
    public static class StringExtensions
    {
        public static bool AsBoolean(this string setting)
        {
            bool.TryParse(setting, out var result);

            return result;
        }
    }
}
