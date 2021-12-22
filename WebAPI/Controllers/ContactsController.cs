using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  //Attribute(classla igili bilgi verme,imzalama yöntemi)
    public class ContactsController : ControllerBase
    {
        //Loosely coupled--gevsek baglilik
        //naming convention
        //IoC Container--Invorsion Of Control
        IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency Chain
            Thread.Sleep(1000);
            var result= _contactService.GetAll();
            if(result.Success)
            {
                return Ok(result);  //get requestlerde 200le calisiriz
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _contactService.GetById(id);
            if(result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Contact contact)
        {
            var result = _contactService.Add(contact);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Contact contact)
        {
            var result = _contactService.Delete(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Contact contact)
        {
            _contactService.Update(contact);
            return Ok();
            //var result = _contactService.Update(contact);
            //if (result.Success)
            //{
            //    return Ok(result);
            //}
            //return BadRequest(result);
        }
    }
}
