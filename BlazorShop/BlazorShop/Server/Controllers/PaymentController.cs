﻿using BlazorShop.Server.Services.PaymentService;
using BlazorShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public ActionResult CreateCheckoutSession(List<CartItem> cartItems) 
        {
            var session = _paymentService.CreateCheckoutSession(cartItems);
            return Ok(session.Url);
        }


    }
}
