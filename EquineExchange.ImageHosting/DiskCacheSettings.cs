namespace EquineExchange.ImageHosting
{
    public static class DiskCacheSettings
    {
        public static bool AsyncWrites { get; } = AppSettings.DiskCache().AsBoolean();

        public static bool Enabled { get; } = AppSettings.DiskCache().AsBoolean();
    }
}
