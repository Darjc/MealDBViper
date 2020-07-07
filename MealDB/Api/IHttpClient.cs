using System;
namespace MealDB.Api
{
    public interface IHttpClient
    {
        string Get(string endpoint, string path);
    }
}
