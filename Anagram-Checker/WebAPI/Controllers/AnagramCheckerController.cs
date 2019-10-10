using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassLibrary;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class AnagramCheckerController : ControllerBase
    {

        [HttpGet]
        [Route("checkAnagram")]
        public IActionResult CheckAnagram([FromBody]Pair words)
        {
            var w1 = words.wordOne.ToCharArray();
            var w2 = words.wordtwo.ToCharArray();

            var check = ClassLibrary.AnagramChecker.IsAnagram(w1, w2);

            if (check)
            {
                return Ok(words.wordOne + " and " + words.wordtwo + "are anagrams.");
            }
            else
            {
                return BadRequest(words.wordOne + " and " + words.wordtwo + "are not anagrams.");
            }
        }
    }
}
