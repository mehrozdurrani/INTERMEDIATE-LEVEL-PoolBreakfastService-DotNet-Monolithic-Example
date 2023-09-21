namespace PoolBreakfast.Tests.Utils.Constants
{
    public static partial class Constants
    {
        public static class BreakfastConstants
        {
            public static readonly Guid Id = Guid.NewGuid();
            public const string Name = "Test Menu Name";
            public const string Description = "Test Menu Description";
            public static readonly DateTime StartDateTime = DateTime.UtcNow;
            public static readonly DateTime EndDateTime = DateTime.UtcNow;
            public static readonly DateTime LastModifiedDateTime = DateTime.UtcNow;
            public static readonly List<string> Savory = new List<string>
            {
                "Test Oatmeal",
                "Test Avocado Toast",
                "Test Omelette",
                "Test Salad"
            };
            public static readonly List<string> Sweet = new List<string>
            {
                "Test Oatmeal",
                "Test Avocado Toast",
                "Test Omelette",
                "Test Salad"
            };
        }
    }
}
