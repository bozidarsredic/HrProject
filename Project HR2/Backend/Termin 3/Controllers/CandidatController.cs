using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Termin_6.Dto;
using Termin_6.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Termin_3.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class CandidatController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IConfiguration conf;

        public CandidatController(IUnitOfWork uow, IConfiguration conf)
        {
            this.uow = uow;
            this.conf = conf;
        }

       [HttpPost("registration")]
        public IActionResult CreateCandidat([FromBody] CandidatDto dto)
        {
           uow.CandidatRepository.CreateCandidat(dto);
               return Ok();
           
        }


        [HttpGet("all")]
        public IActionResult GetAll()
        {

            return Ok(uow.CandidatRepository.GetAllCandidats());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(uow.CandidatRepository.GetUserById(id));
        }

        [HttpPost("deletecandidat")]
        public IActionResult DeleteCandidat([FromBody] int id)
        {
            uow.CandidatRepository.DeleteCandidat(id);

            return Ok();
        }







    }
}
