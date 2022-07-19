using BesmirMiftariPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BesmirMiftariPortfolio.API_s {
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase {
     
        [HttpGet]
        public IEnumerable<User> Get() {
            return Comments.AllComments;
        }

        [HttpPost]
        [Route("add")]
        public OkResult Post(User newUserComment) {

            Comments.AllComments.Add(newUserComment);

            return Ok();
        }
       
    }
}
