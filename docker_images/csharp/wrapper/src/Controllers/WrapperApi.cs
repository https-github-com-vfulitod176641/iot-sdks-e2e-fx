/*
 * Azure IOT End-to-End Test Wrapper Rest Api
 *
 * REST API definition for End-to-end testing of the Azure IoT SDKs.  All SDK APIs that are tested by our E2E tests need to be defined in this file.  This file takes some liberties with the API definitions.  In particular, response schemas are undefined, and error responses are also undefined.
 *
 * OpenAPI spec version: 1.0.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{
    /// <summary>
    ///
    /// </summary>
    public class WrapperApiController : Controller
    {
        // Added 1 line in merge
        internal WrapperGlue wrapper_glue = new WrapperGlue();

        /// <summary>
        /// verify that the clients have cleaned themselves up completely
        /// </summary>

        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/wrapper/cleanup")]
        [ValidateModelState]
        [SwaggerOperation("WrapperCleanup")]
        public virtual IActionResult WrapperCleanup()
        {
            // Changed impl in merge
            wrapper_glue.CleanupResourcesAsync().Wait();
            return StatusCode(200);

        }

        /// <summary>
        /// Get capabilities for this test wrapper
        /// </summary>

        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/wrapper/capabilities")]
        [ValidateModelState]
        [SwaggerOperation("WrapperGetCapabilities")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult WrapperGetCapabilities()
        {
            // Changed impl in merge
            throw new NotImplementedException();
        }

        /// <summary>
        /// log a message to output
        /// </summary>

        /// <param name="msg"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/wrapper/message")]
        [ValidateModelState]
        [SwaggerOperation("WrapperLogMessage")]
        public virtual IActionResult WrapperLogMessage([FromBody]Object msg)
        {
            // Changed impl in merge
            wrapper_glue.PrintMessageAsync(msg.ToString()).Wait();
            return StatusCode(200);
        }

        /// <summary>
        /// send an arbitrary command
        /// </summary>

        /// <param name="cmd">command string</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/wrapper/command")]
        [ValidateModelState]
        [SwaggerOperation("WrapperSendCommand")]
        public virtual IActionResult WrapperSendCommand([FromQuery][Required()]string cmd)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// set flags for the wrapper to use
        /// </summary>

        /// <param name="flags"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/wrapper/flags")]
        [ValidateModelState]
        [SwaggerOperation("WrapperSetFlags")]
        public virtual IActionResult WrapperSetFlags([FromBody]Object flags)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }
    }
}
