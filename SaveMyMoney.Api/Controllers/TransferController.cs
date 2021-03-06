﻿using Microsoft.AspNetCore.Mvc;
using SaveMyMoney.Domain.Commands.Requests.Transfers;
using SaveMyMoney.Domain.Handlers;
using System;

namespace SaveMyMoney.Api.Controllers
{
    [ApiController]
    [Route("transfer")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferHandler _handler;

        public TransferController(ITransferHandler handler)
        {
            _handler = handler;
        }

        [Route("")]
        [HttpPost]
        public IActionResult Post([FromBody] RegisterTransferRequest req)
        {
            try
            {
                var response = _handler.Post(req);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                var response = _handler.GetById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var response = _handler.GetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _handler.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("")]
        [HttpPut]
        public IActionResult Update([FromBody] UpdateTransferRequest req)
        {
            try
            {
                _handler.Update(req);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
