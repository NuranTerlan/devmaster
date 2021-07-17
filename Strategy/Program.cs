namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = new ImageStorage();
            storage.Store("directory1/kingimage", CompressMethods.Jpeg, FilterMethods.HighContrast);
            storage.Store("directory2/kingimage", CompressMethods.Png, FilterMethods.BlackAndWhite);
        }
    }
}