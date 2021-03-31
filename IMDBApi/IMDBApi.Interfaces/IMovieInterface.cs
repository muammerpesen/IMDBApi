using IMDBApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDBApi.Interfaces
{
    public interface IMovieInterface
    {
        public MovieModel GetMovie(string movieID);
    }
}
