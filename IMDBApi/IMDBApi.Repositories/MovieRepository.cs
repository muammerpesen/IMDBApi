using System;
using System.Collections.Generic;
using System.Text;
using IMDBApi.HelperClass;
using IMDBApi.Interfaces;
using IMDBApi.Models;
using IMDBApi.Repositories.HelperClass;
using Newtonsoft.Json.Linq;

namespace IMDBApi.Repositories
{
    public class MovieRepository : IMovieInterface
    {
        public MovieRepository()
        {
        }


        public MovieModel GetMovie(string movieID)
        {
            HTMLParser htmlParser = new HTMLParser();
            string finalURL = ConstVariables.MainURL + ConstVariables.MovieURL + movieID;
            var responseString = htmlParser.GetMovie(finalURL);
            JObject jObject = JObject.Parse(responseString);

            MovieModel movieModel = new MovieModel();
            movieModel.Type = jObject["@type"].ToString();
            movieModel.Url = jObject["url"].ToString();
            movieModel.Name = jObject["name"].ToString();
            movieModel.Image = jObject["image"].ToString();
            movieModel.ContentRating = jObject["contentRating"].ToString();
            movieModel.Description = jObject["description"].ToString();
            movieModel.DatePublished = jObject["datePublished"].ToString();
            movieModel.Keywords = jObject["keywords"].ToString();
            movieModel.Keywords = jObject["keywords"].ToString();
            movieModel.Genre = Helper.SetGenre(jObject["genre"]);
            movieModel.Actor = Helper.SetActor(jObject["actor"]);
            movieModel.Creator = Helper.SetActor(jObject["creator"]); 

            return movieModel;
        }
    }
}
