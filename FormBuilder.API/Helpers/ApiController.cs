using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormBuilder.API.Helpers
{
    public class ApiController : Controller
    {

        #region Ok

        [NonAction]
        public override OkResult Ok()
        {
            IActionResult result = StatusCode(200, new APIResponse(true));

            return base.Ok();
        }

        [NonAction]
        public override OkObjectResult Ok(object value)
        {
            return base.Ok(new APIResponse(value, true, null));
        }

        [NonAction]
        public virtual OkObjectResult Ok(object value, params string[] messages)
        {
            return base.Ok(new APIResponse(value, true, messages));
        }

        #endregion

        #region NotFound

        [NonAction]
        public override NotFoundResult NotFound()
        {
            IActionResult result = StatusCode(404, new APIResponse(false, "Couldn't find the record"));
            return result as NotFoundResult;
        }

        [NonAction]
        public override NotFoundObjectResult NotFound(object value)
        {
            return base.NotFound(new APIResponse(null, false, $"Couldn't find the record: ${value}"));
        }

        [NonAction]
        public virtual NotFoundObjectResult NotFound(object value, params string[] messages)
        {
            var listMessages = messages.ToList();
            listMessages.Add(value.ToString());
            return base.NotFound(new APIResponse(null, false, listMessages.ToArray()));
        }

        #endregion

        #region BadRequest

        [NonAction]
        public override BadRequestResult BadRequest()
        {
            IActionResult result = StatusCode(400, new APIResponse(false, "That request was invalid"));
            return result as BadRequestResult;
        }

        [NonAction]
        public override BadRequestObjectResult BadRequest(object value)
        {
            return base.BadRequest(new APIResponse(value, false, $"That request was invalid: {value}"));
        }

        [NonAction]
        public virtual BadRequestObjectResult BadRequest(object value, params string[] messages)
        {
            return base.BadRequest(new APIResponse(value, false, messages));
        }

        #endregion

        #region UnAuthorized

        [NonAction]
        public override UnauthorizedResult Unauthorized()
        {
            IActionResult result = StatusCode(401, new APIResponse(false, "This action requires authentication"));
            return result as UnauthorizedResult;
        }

        #endregion
    }
}
