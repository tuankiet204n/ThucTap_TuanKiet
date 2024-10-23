﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThucTap_TuanKiet.Model;
using ThucTap_TuanKiet.Services;
namespace ThucTap_TuanKiet.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AccountAnswersController : ControllerBase
    {
        private readonly IAccountAnswer accountAnswer;
        public AccountAnswersController(IAccountAnswer accountAnswer)
        {
            this.accountAnswer = accountAnswer;
        }
        [HttpGet("{idQuestion}")]
        public ActionResult GetByIdQuestion(int idQuestion)
        {
            return Ok(accountAnswer.GetByIdQuestion(idQuestion));
        }
        [HttpPost]
        public ActionResult Add(int idQuestion, int idAnswer, int idAccount)
        {
            var acAn = accountAnswer.AddAccountAnswer(idQuestion, idAnswer, idAccount);
            if (acAn == null)
                return BadRequest();
            return CreatedAtAction("Add", acAn);
        }
    }
}
