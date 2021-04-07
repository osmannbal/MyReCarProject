using Business.Abstract;
using Entities.Concrete;
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
    public class PaymentsController : ControllerBase
    {
        IPaymentService _paymentService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        
        [HttpPost("payment")]
        public IActionResult Pay(Payment payment)
        {
            var paymentResult = _paymentService.Pay(payment);
            if (paymentResult.Success)
            {
                return Ok(paymentResult);
            }
            return BadRequest(paymentResult);
        }
    }
}
