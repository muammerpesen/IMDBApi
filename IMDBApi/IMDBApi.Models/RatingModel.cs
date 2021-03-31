using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBApi.Models
{
    public class RatingModel
    {
        public string Type { get; set; }
        public string RatingCount { get; set; }
        public string BestRating { get; set; }
        public string WorstRating { get; set; }
        public string RatingValue { get; set; }
    }
}
