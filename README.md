# CommercialOptimizer
An ASP.NET Web API project to generate optimized commercials based on highest possible rating.
.NET 7.0

To check the outputs:
1. Run the solution and select 'Try it out'>'Execute' on the swagger page for either /OptimizedCommercials or /OptimizedCommercialsBonus
2. OR in postman add new GET request for either https://localhost:[portnumber]/OptimizedCommercials or https://localhost:[portnumber]/OptimizedCommercialsBonus

Two end points created:
1. /OptimizedCommercials - produces 3 commercial breaks with 3 commercials each. Commercials dataset contains 9 entries
2. /OptimizedCommercials - produces 3 commercial breaks with 2, 3, and 4 commercials each. Commercials dataset contains 10 entries
