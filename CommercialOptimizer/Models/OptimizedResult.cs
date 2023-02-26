using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CommercialOptimizer.Models
{
    
    public class OptimizedResult
    {
        List<Break> breaks = new List<Break>();

        [JsonProperty]        
        IEnumerable<Break> Breaks { get { return breaks; } }

        public void AddBreaks(Break commercialBreak)
        {
            breaks.Add(commercialBreak);
        }

        public int TotalRating 
        {
            get 
            {
                return breaks.Count() > 0 ? breaks.Sum(b => b.TotalRating) : 0;
            }
        }
    }
}
