using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Data;
using api.Mappers;
//using api.Migrations;


namespace api.Controllers
{

    [Route("api/users")]
    [ApiController]


    public class UserController: ControllerBase
    {
        private readonly ApplicationDbContext _context;


        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }    

    
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _context.Users
                .ToList()
                .Select(s => s.ToUsersDto());
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user.ToUsersDto());
        }

    }
}







    //    [Route("api / users")]
    //    [ApiController]

    //    public class UserController : ControllerBase
    //    {
    //        private readonly ApplicationDbContext _context;
    //        public UserController(ApplicationDbContext context)
    //        {
    //            _context = context;
    //        }


    //        [HttpGet]
    //        public IactioResult Create([Frombody] CreateStockRequest stockDto)
    //        {

    //        }



    //        [HttpGet]




    //        }

    ////        [HttpGet("{id}")]

    ////        public IActionResult getById[(FromRoute)int id]{

    ////          var user = _context.Users.Find(id);

    ////        if(user == null){
    ////            return NotFound();
    ////    }
    ////              return Ok(user);
    ////}
    //        }