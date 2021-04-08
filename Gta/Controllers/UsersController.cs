using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gta.Application.interfaces;
using Gta.Application.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(this.userService.GetAll());
        }


        [HttpPost]
        public IActionResult Post([FromBody] MainViewModel[] mainViewModel)
        {
            return Ok(this.userService.Post(mainViewModel));
        }

        [HttpGet("{id}")]
        public IActionResult GetParcels(String Id)
        {
            return Ok(this.userService.GetById(Id));
        }

        [HttpPut]
        public IActionResult Put(UserViewModel userViewModel)
        {
            return Ok(this.userService.Put(userViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(String Id)
        {
            return Ok(this.userService.Delete(Id));
        }
    }
}