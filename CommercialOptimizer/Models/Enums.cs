using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

namespace CommercialOptimizer.Models
{
    public enum Demographics
    {
        [EnumMember(Value = "W25-30")]
        W2530 = 0,
        [EnumMember(Value = "M18-35")]
        M1835 = 1,
        [EnumMember(Value = "T18-40")]
        T1840 = 2
    }

    public enum CommercialTypes
    {
        [EnumMember(Value = "Automotive")]
        Automotive = 0,
        [EnumMember(Value = "Travel")]
        Travel = 1,
        [EnumMember(Value = "Finance")]
        Finance = 2
    }
}
