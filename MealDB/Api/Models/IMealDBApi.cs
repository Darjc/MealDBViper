using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MealDB.Api.Models.Response;
using Refit;

namespace MealDB.Api.Models
{
    public interface IMealDBApi
    {
        [Get("/search.php?s={**nameQuery}")]
        Task<MealListResponse> Search(string nameQuery);
        [Get("/lookup.php?i={**id}")]
        Task<MealListResponse> GetById(string id);
    }
}
