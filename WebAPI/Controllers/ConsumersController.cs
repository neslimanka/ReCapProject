using Core.Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumersController : ControllerBase
    {
        IConsumerService _consumerService;

        public ConsumersController(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _consumerService.GetAll();
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _consumerService.GetById(id);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Consumer consumer)
        {
            var result = _consumerService.Add(consumer);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Consumer consumer)
        {
            var result = _consumerService.Update(consumer);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Consumer consumer)
        {
            var result = _consumerService.Delete(consumer);
            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
