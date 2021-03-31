using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDBApi.Interfaces;
using IMDBApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IMDBApi.Controllers
{
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private IMovieInterface repository;

        public MovieController(IMovieInterface repo)
        {
            repository = repo;
        }


        [HttpGet]
        public IMDBApi.Models.MovieModel GetMovie()
        {
            var returnModel = repository.GetMovie("tt5753856");

            return returnModel;

        }
    }
}
