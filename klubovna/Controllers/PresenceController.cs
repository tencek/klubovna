using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace klubovna.Controllers
{
    [Route("api/[controller]")]
    public class PresenceController : Controller
    {
        private bool _presence = false;

        // GET api/presence
        [HttpGet]
        public bool Get()
        {
            return _presence;
        }

        // POST api/presence
        [HttpPost]
        public void Post([FromBody]bool value)
        {
            _presence = value;
        }
    }
}
