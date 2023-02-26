using CommercialOptimizer.Data;
using CommercialOptimizer.Models;

namespace CommercialOptimizer.Engine
{
    public class CommercialOptimizerEngine
    {

        public OptimizedResult GenerateOptimizedCommercials(List<Commercial> commercials, List<Break> breaks)
        { 
            var optimizedResult = new OptimizedResult();

            var breakLookup = DataGenerator.GenerateBreakLookups;

            foreach(var breakItem in breaks)
            {
                // if we are on the last commercials, 
                // check the item orders and re-arrange if needed
                if (breakItem.Slots == commercials.Count())
                {
                    commercials = ReOrderCommercial(commercials);
                }

                GenerateCommercialBreaks(breakItem, commercials, breakLookup);

                optimizedResult.AddBreaks(breakItem);

                RemoveAllotedCommercials(commercials, breakItem.Commercials);
            }        

            return optimizedResult;
        }

        private List<Commercial> ReOrderCommercial(List<Commercial> commercials)
        {
            List<Commercial> commercialCopy = new List<Commercial>(commercials);


            List<int> problemIndex = new List<int>();
            for (int idx = 0; idx < commercialCopy.Count(); idx++)
            {
                if (idx + 1 < commercialCopy.Count())
                {
                    if (commercialCopy[idx].CommercialType == commercialCopy[idx + 1].CommercialType)
                    {
                        problemIndex.Add(idx);
                    }
                }
            }

            foreach (var p in problemIndex)
            {
                if (p > 0)
                {
                    var a = commercialCopy[p - 1];
                    var b = commercialCopy[p];

                    commercialCopy[p] = a;
                    commercialCopy[p - 1] = b;
                }

            }

            return commercialCopy;
        }

        private void GenerateCommercialBreaks(Break breakItem, List<Commercial> commercials, List<BreakLookupItem> breakLookup)
        {
            var highestToLowestRating = breakLookup.Where(b => b.Id == breakItem.Number).OrderBy(b => b.Rating).Reverse().ToList();

            var commercialCopy = new List<Commercial>(commercials);

            for (int highLowIndex = 0; highLowIndex < highestToLowestRating.Count(); highLowIndex++)
            {
                if (breakItem.Commercials.Count == breakItem.Slots)
                    break;

                var commercial = commercialCopy.FirstOrDefault(c => c.Demographic == highestToLowestRating[highLowIndex].Demographic);
                if (commercial != null)
                {
                    commercial.Rating = highestToLowestRating[highLowIndex].Rating;
                    breakItem.AddCommercial(commercial);           
                    commercialCopy.Remove(commercial);
                    highLowIndex -= 1;
                }
            }

            if (breakItem.Commercials.Count < breakItem.Slots)
            {
                GenerateCommercialBreaks(breakItem, commercials, breakLookup);
            }
        }

        private void RemoveAllotedCommercials(List<Commercial> commercials, List<Commercial> allotedCommercials)
        {
            //removed already added commercials
            foreach (var al in allotedCommercials)
            {
                var toRemove = commercials.FirstOrDefault(c => c.Name == al.Name);
                if (toRemove != null)
                    commercials.Remove(toRemove);
            }
        }

        

        
    }
}
