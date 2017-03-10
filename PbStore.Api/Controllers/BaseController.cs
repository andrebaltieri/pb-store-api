using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidator;
using Microsoft.AspNetCore.Mvc;

namespace PbStore.Api.Controllers
{
    public class BaseController : Controller
    {
        public async Task<IActionResult> Response(
            object result,
            string successMessage,
            string errorMessage,
            IReadOnlyCollection<Notification> notifications)
        {
            if (notifications.Count == 0)
            {
                return Ok(new
                {
                    success = true,
                    message = successMessage,
                    data = result,
                    errors = notifications
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    message = errorMessage,
                    errors = notifications
                });
            }
        }
    }
}
