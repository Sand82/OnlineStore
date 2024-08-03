namespace OnlineStore.Domain.Constants
{
    public static class ValidationConstants
    {
        public static class ItemConstant
        {
            public const int NameLength = 100;

            public const int CodeMinValue = 3;
            public const int CodeMaxValue = 7;

            public const int DescriptionMaxLength = 65535;

            public const string PriceMaxValue = "79228162514264337593543950335";
            public const string PriceMinValue = "0";

            public const int ImageUrlLength = 500;
        }

        public static class CategoryConstant
        {
            public const int NameLength = 100;
        }

        public static class CategoryMainConstant
        {
            public const int NameLength = 50;
        }
    }
}
