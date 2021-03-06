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
    public class ServiceApiController : Controller
    {
        // Added 1 line in merge
        static internal ServiceGlue service_glue = new ServiceGlue();

        /// <summary>
        /// Connect to service
        /// </summary>
        /// <remarks>Connect to the Azure IoTHub service.  More specifically, the SDK saves the connection string that is passed in for future use.</remarks>
        /// <param name="connectionString">connection string</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/service/connect")]
        [ValidateModelState]
        [SwaggerOperation("ServiceConnect")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConnectResponse), description: "OK")]
        public virtual IActionResult ServiceConnect([FromQuery][Required()]string connectionString)
        {
            // Replaced impl in merrge
            Task<ConnectResponse> t = service_glue.ConnectAsync(connectionString);
            t.Wait();
            return new ObjectResult(t.Result);
        
        }

        /// <summary>
        /// Disconnect from the service
        /// </summary>
        /// <remarks>Disconnects from the Azure IoTHub service.  More specifically, closes all connections and cleans up all resources for the active connection</remarks>
        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/service/{connectionId}/disconnect/")]
        [ValidateModelState]
        [SwaggerOperation("ServiceDisconnect")]
        public virtual IActionResult ServiceDisconnect([FromRoute][Required]string connectionId)
        {
            // replced impl in merge
            service_glue.DisconnectAsync(connectionId).Wait();
            return StatusCode(200);
        }

        /// <summary>
        /// call the given method on the given device
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="deviceId"></param>
        /// <param name="methodInvokeParameters"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/service/{connectionId}/deviceMethod/{deviceId}")]
        [ValidateModelState]
        [SwaggerOperation("ServiceInvokeDeviceMethod")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult ServiceInvokeDeviceMethod([FromRoute][Required]string connectionId, [FromRoute][Required]string deviceId, [FromBody]MethodInvoke methodInvokeParameters)
        {
            // Replaced impl in merge
            Task<object> t = service_glue.InvokeDeviceMethodAsync(connectionId, deviceId, methodInvokeParameters);
            t.Wait();
            return new ObjectResult(t.Result);


        }

        /// <summary>
        /// call the given method on the given module
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="deviceId"></param>
        /// <param name="moduleId"></param>
        /// <param name="methodInvokeParameters"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/service/{connectionId}/moduleMethod/{deviceId}/{moduleId}")]
        [ValidateModelState]
        [SwaggerOperation("ServiceInvokeModuleMethod")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult ServiceInvokeModuleMethod([FromRoute][Required]string connectionId, [FromRoute][Required]string deviceId, [FromRoute][Required]string moduleId, [FromBody]MethodInvoke methodInvokeParameters)
        {
            // Replaced impl in merge
            Task<object> t = service_glue.InvokeModuleMethodAsync(connectionId, deviceId, moduleId, methodInvokeParameters);
            t.Wait();
            return new ObjectResult(t.Result);
        }

        /// <summary>
        /// Send a c2d message
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="deviceId"></param>
        /// <param name="eventBody"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/service/{connectionId}/sendC2d/{deviceId}")]
        [ValidateModelState]
        [SwaggerOperation("ServiceSendC2d")]
        public virtual IActionResult ServiceSendC2d([FromRoute][Required]string connectionId, [FromRoute][Required]string deviceId, [FromBody]EventBody eventBody)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }
    }
}
