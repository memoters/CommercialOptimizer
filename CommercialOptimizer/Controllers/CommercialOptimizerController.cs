using CommercialOptimizer.Data;
using CommercialOptimizer.Engine;
using CommercialOptimizer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace CommercialOptimizer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommercialOptimizerController : ControllerBase
    {
        private readonly ILogger<CommercialOptimizerController> _logger;

        public CommercialOptimizerController(ILogger<CommercialOptimizerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/OptimizedCommercials")]
        public ActionResult<OptimizedResult> GetOptimizedCommercials()
        {
            CommercialOptimizerEngine engine = new CommercialOptimizerEngine();
            OptimizedResult result = engine.GenerateOptimizedCommercials(DataGenerator.GenerateCommercials, DataGenerator.Breaks);

            return Ok(result);
        }

        [HttpGet("~/OptimizedCommercialsBonus")]
        public ActionResult<OptimizedResult> GetOptimizedCommercialsBonus()
        {
            CommercialOptimizerEngine engine = new CommercialOptimizerEngine();
            OptimizedResult result = engine.GenerateOptimizedCommercials(DataGenerator.GenerateCommercialsBonus, DataGenerator.BreaksBonus);

            return Ok(result);
        }
    }
}