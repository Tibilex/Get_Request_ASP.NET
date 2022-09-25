namespace ASPNET_1.Models
{
    public class PhoneModel
    {
        public string? ModelName { get; set; }

        public string? Manufacturer { get; set; }

        public int Price { get; set; }

        public string? PhisicMemory { get; set; }

        public string? RAM { get; set; }

        public double DisplaySize { get; set; }

        public string? DisplayType { get; set; }

        public string? Os { get; set; }

        public string? Camera { get; set; }

        public PhoneModel(string? modelName, string? manufacturer, int price, string? phisicMemory, string? rAM, double displaySize, string? displayType, string? os, string? camera)
        {
            ModelName = modelName;
            Manufacturer = manufacturer;
            Price = price;
            PhisicMemory = phisicMemory;
            RAM = rAM;
            DisplaySize = displaySize;
            DisplayType = displayType;
            Os = os;
            Camera = camera;
        }
    }
}
