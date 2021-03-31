using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBApi.Models
{
    public class MovieModel
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public List<GenreModel> Genre { get; set; }
        public string ContentRating { get; set; }
        public List<ActorModel> Actor { get; set; }
        public List<ActorModel> Creator { get; set; }
        public string Description { get; set; }
        public string DatePublished{ get; set; }
        public string Keywords { get; set; }
        public List<RatingModel> Rating { get; set; }
        public string DateCreated { get; set; }
        public string Language { get; set; }

    }
}
