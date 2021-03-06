﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.API.Helpers;
using FormBuilder.API.Models.Forms;
using FormBuilder.Data.Entities;
using FormBuilder.DataService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FormBuilder.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/forms")]
    public class FormsController : ApiController
    {
        private readonly IFormService formService;
        private readonly IFormAnswerService formAnswerService;
        public FormsController(IFormService formService,
                               IFormAnswerService formAnswerService)
        {
            this.formService = formService;
            this.formAnswerService = formAnswerService;
        }


        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]CreateFormModel model)
        {
            var form = new Form()
            {
                FormSchema = model.FormSchema,
                Name = model.FormName,
                Url = model.FormName.GetFriendlyUrl(),
                Key = Guid.NewGuid()
            };
            if (formService.Add(form))
                return Ok(form);
            return BadRequest();
        }

        [Route("get/{id}")]
        [HttpGet]
        public IActionResult Get(Guid? id)
        {
            if (!id.HasValue) return BadRequest();
            var form = formService.GetFormById(id.Value);
            form.Key = Guid.Empty;
            return Ok(form);
        }

        [HttpPost]
        [Route("answer")]
        public async Task<IActionResult> Answer()
        {
            string content;
            using (var reader = new StreamReader(Request.Body))
            {
                content = await reader.ReadToEndAsync();
            }

            var jsonBody = JsonConvert.DeserializeObject<Dictionary<string, object>>(content);

            var newAnswer = new FormAnswer()
            {
                FormId = Guid.Parse(jsonBody["FormId"] as string),
                Answer = jsonBody["Answer"] as string
            };

            if (formAnswerService.Add(newAnswer))
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("getanswers/{key}")]
        public IActionResult GetAnswers(Guid? key)
        {
            if (!key.HasValue) return BadRequest();

            return Ok(formAnswerService.GetFormAnswersByKey(key.Value));
        }
    }
}
