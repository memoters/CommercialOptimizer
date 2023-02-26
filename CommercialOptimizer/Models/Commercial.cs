using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CommercialOptimizer.Models
{
    public class Commercial
    {
        private const int FINANCE_RESTRICTED_BREAK = 2;
        public string Name { get; set; }
        
        public int Id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CommercialTypes CommercialType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Demographics Demographic { get; set; }

        public int RestrictedBreakNumber 
        {
            get 
            {
                return CommercialType == CommercialTypes.Finance ? FINANCE_RESTRICTED_BREAK : 0;
            }
        }

        public int Rating { get; set; }
    }
}
