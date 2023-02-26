using CommercialOptimizer.Models;

namespace CommercialOptimizer.Data
{
    public static class DataGenerator
    {
        public static List<Commercial> GenerateCommercials 
        {
            get
            {
                List<Commercial> commercials = new List<Commercial>();

                commercials.Add(new Commercial() { Id = 1, Name = "Commercial1", CommercialType = CommercialTypes.Automotive, Demographic = Demographics.W2530 });
                commercials.Add(new Commercial() { Id = 2, Name = "Commercial2", CommercialType = CommercialTypes.Travel, Demographic = Demographics.M1835 });
                commercials.Add(new Commercial() { Id = 3, Name = "Commercial3", CommercialType = CommercialTypes.Travel, Demographic = Demographics.T1840 });
                commercials.Add(new Commercial() { Id = 4, Name = "Commercial4", CommercialType = CommercialTypes.Automotive, Demographic = Demographics.M1835 });
                commercials.Add(new Commercial() { Id = 5, Name = "Commercial5", CommercialType = CommercialTypes.Automotive, Demographic = Demographics.M1835 });
                commercials.Add(new Commercial() { Id = 6, Name = "Commercial6", CommercialType = CommercialTypes.Finance, Demographic = Demographics.W2530 });
                commercials.Add(new Commercial() { Id = 7, Name = "Commercial7", CommercialType = CommercialTypes.Finance, Demographic = Demographics.M1835 });
                commercials.Add(new Commercial() { Id = 8, Name = "Commercial8", CommercialType = CommercialTypes.Automotive, Demographic = Demographics.T1840 });
                commercials.Add(new Commercial() { Id = 9, Name = "Commercial9", CommercialType = CommercialTypes.Travel, Demographic = Demographics.W2530 });

                return commercials;
            }
        }

        public static List<Commercial> GenerateCommercialsBonus
        {
            get
            {
                var commercials = GenerateCommercials;
                commercials.Add(new Commercial() { Id = 10, Name = "Commercial10", CommercialType = CommercialTypes.Finance, Demographic = Demographics.T1840 });

                return commercials;
            }
        }

        public static List<BreakLookupItem> GenerateBreakLookups
        {
            get
            {
                List<BreakLookupItem> breakLookupItems = new List<BreakLookupItem>();

                breakLookupItems.Add(new BreakLookupItem() { Id = 1, Demographic = Demographics.W2530, Rating = 80 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 1, Demographic = Demographics.M1835, Rating = 100 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 1, Demographic = Demographics.T1840, Rating = 250 });

                breakLookupItems.Add(new BreakLookupItem() { Id = 2, Demographic = Demographics.W2530, Rating = 50 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 2, Demographic = Demographics.M1835, Rating = 120 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 2, Demographic = Demographics.T1840, Rating = 200 });

                breakLookupItems.Add(new BreakLookupItem() { Id = 3, Demographic = Demographics.W2530, Rating = 350 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 3, Demographic = Demographics.M1835, Rating = 150 });
                breakLookupItems.Add(new BreakLookupItem() { Id = 3, Demographic = Demographics.T1840, Rating = 500 });

                return breakLookupItems;
            }
        }

        public static List<Break> Breaks 
        { 
            get 
            {
                List<Break> breaks = new List<Break>();
                breaks.Add(new Break() { Number = 1, Slots = 3 });
                breaks.Add(new Break() { Number = 2, Slots = 3 });
                breaks.Add(new Break() { Number = 3, Slots = 3 });

                return breaks;
            } 
        }

        public static List<Break> BreaksBonus
        {
            get 
            {
                List<Break> breaks = new List<Break>();
                breaks.Add(new Break() { Number = 1, Slots = 2 });
                breaks.Add(new Break() { Number = 2, Slots = 3 });
                breaks.Add(new Break() { Number = 3, Slots = 4 });

                return breaks;
            }
        }
    }
}
