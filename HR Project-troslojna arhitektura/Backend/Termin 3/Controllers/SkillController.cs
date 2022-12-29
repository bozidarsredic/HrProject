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
using Termin_6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com /fwlink/?LinkID=397860

namespace Termin_3.Controllers
{
    [Route("api/skill")]
    [ApiController]
    public class SkillControler : ControllerBase
    {
        private readonly ISkillService skillService;
        private readonly IConfiguration conf;

        public SkillControler(ISkillService skillService, IConfiguration conf)
        {
            this.skillService = skillService;
            this.conf = conf;
        }

        [HttpPost("add")]
        public IActionResult AddSkill([FromBody] SkillDto dto)
        {

            skillService.CreateSkill(dto);
            return Ok();

        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {

            return Ok(skillService.GetAllSkills());
        }

        [HttpPost("addskilltocandidat")]
        public IActionResult AddSkillToCandidat([FromBody] CandidatSkillDto dto)
        {

            skillService.AddSkillToCandidat(dto);
            return Ok();

        }

        [HttpGet("{id}")]
        public IActionResult GetSkillsById(int id)
        {
            return Ok(skillService.GetSkillsById(id));
        }

        [HttpPost("getavailableskills")]

        public IActionResult Getavailableskillsbyid([FromBody] int id)
        {
            return Ok(skillService.GetAvailableSkillsById(id));
        }

     

        [HttpPost("deleteskilltocandidat")]
        public IActionResult DeleteSkillToCandidat([FromBody] CandidatSkillDto dto)
        {

            skillService.DeleteSkillToCandidat(dto);
            return Ok();

        }


      








    }
}
