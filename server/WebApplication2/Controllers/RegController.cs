using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication2.Models;
using WebApplication2.RegRequest;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
	public class RegController : ApiController
	{
		RegService regService = new RegService();

		[HttpGet, Route("api/user")]
		public List<RegModel> GetAll()
		{
			List<RegModel> regList = regService.GetAll();

			return regList;
		}

		[HttpPost, Route("api/user")]
		public HttpResponseMessage Create(CreateRegRequest regRequest)
		{
			if (regRequest == null)
			{
				ModelState.AddModelError("", "Missing body data");
			}
			if (!ModelState.IsValid)
			{
				return Request.CreateErrorResponse
					(HttpStatusCode.BadRequest, ModelState);
			}
			int newId = regService.Create(regRequest);
			return Request.CreateResponse(HttpStatusCode.OK, newId);
		}


		[HttpPut, Route("api/user/{id:int}")]
		public HttpResponseMessage Update(int id, UpdateRegRequest req)
		{
			// call into your service here
			return Request.CreateResponse(HttpStatusCode.OK);
		}

		[HttpDelete, Route("api/user/{id:int}")]
		public HttpResponseMessage Delete(int id)
		{
			// call into your service here
			return Request.CreateResponse(HttpStatusCode.OK);
		}
	}
}





