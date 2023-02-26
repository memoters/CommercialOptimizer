using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using JsConverter = System.Text.Json.Serialization.JsonConverter;


namespace CommercialOptimizer.Models
{    
    public class Break
    {
        public int Number { get; set; }

        public int Slots { get; set; }

        private List<Commercial> commercials = new List<Commercial>();
        [JsonProperty]
        public List<Commercial> Commercials { get { return commercials; } }
        
        public int TotalRating 
        {
            get 
            {
                return commercials.Count > 0 ? commercials.Sum(c => c.Rating) : 0;
            }
        }

        public bool AddCommercial(Commercial commercial)
        {
            bool isAdded = false;
            if (commercial.RestrictedBreakNumber != this.Number)
            {
                if (commercials.Count == 0)
                {
                    commercials.Add(commercial);
                    isAdded = true;
                }
                else if(!commercials.Exists(c => c.Id == commercial.Id) 
                    && commercials.Last().CommercialType != commercial.CommercialType)
                {
                    commercials.Add(commercial);
                    isAdded = true;
                }
            }

            return isAdded;
        }
    }
   
}
