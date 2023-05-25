﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpraHomeWork.Service.Response;

namespace SimpraHomework.Apı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        //Bu bır endpoınt degıl, kendı ıcımde metodu kullanacagım.
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponse<T> response)
        {

            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
