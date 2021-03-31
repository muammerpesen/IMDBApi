using IMDBApi.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDBApi.Repositories.HelperClass
{
    public class Helper
    {

        public static List<GenreModel> SetGenre(JToken jToken)
        {
            List<GenreModel> genreModel = new List<GenreModel>();
            foreach (var item in jToken)
            {
                GenreModel genreListItem = new GenreModel();
                genreListItem.Name = item.ToString();
                genreListItem.Value = item.ToString();
                genreModel.Add(genreListItem);
            }

            return genreModel;
        }

        public static List<ActorModel> SetActor(JToken jToken)
        {
            List<ActorModel> actorModel = new List<ActorModel>();
            foreach (var item in jToken)
            {
                if (Convert.ToString(item["@type"]) == "Person")
                {
                    ActorModel actorListItem = new ActorModel();
                    actorListItem.Type = item["@type"].ToString();
                    actorListItem.Url = item["url"].ToString();
                    actorListItem.Name = item["name"].ToString();
                    actorModel.Add(actorListItem);
                }
            }

            return actorModel;
        }


    }
}
