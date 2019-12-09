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
    public class DeviceApiController : Controller
    {
        /// <summary>
        /// Connect to the azure IoT Hub as a device
        /// </summary>

        /// <param name="transportType">Transport to use</param>
        /// <param name="connectionString">connection string</param>
        /// <param name="caCertificate"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/connect/{transportType}")]
        [ValidateModelState]
        [SwaggerOperation("DeviceConnect")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConnectResponse), description: "OK")]
        public virtual IActionResult DeviceConnect([FromRoute][Required]string transportType, [FromQuery][Required()]string connectionString, [FromBody]Certificate caCertificate)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConnectResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"connectionId\" : \"connectionId\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConnectResponse>(exampleJson)
            : default(ConnectResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Connect the device
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/connect2")]
        [ValidateModelState]
        [SwaggerOperation("DeviceConnect2")]
        public virtual IActionResult DeviceConnect2([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a device client from a connection string
        /// </summary>

        /// <param name="transportType">Transport to use</param>
        /// <param name="connectionString">connection string</param>
        /// <param name="caCertificate"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/createFromConnectionString/{transportType}")]
        [ValidateModelState]
        [SwaggerOperation("DeviceCreateFromConnectionString")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConnectResponse), description: "OK")]
        public virtual IActionResult DeviceCreateFromConnectionString([FromRoute][Required]string transportType, [FromQuery][Required()]string connectionString, [FromBody]Certificate caCertificate)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConnectResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"connectionId\" : \"connectionId\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConnectResponse>(exampleJson)
            : default(ConnectResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Create a device client from X509 credentials
        /// </summary>

        /// <param name="transportType">Transport to use</param>
        /// <param name="x509"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/createFromX509/{transportType}")]
        [ValidateModelState]
        [SwaggerOperation("DeviceCreateFromX509")]
        [SwaggerResponse(statusCode: 200, type: typeof(ConnectResponse), description: "OK")]
        public virtual IActionResult DeviceCreateFromX509([FromRoute][Required]string transportType, [FromBody]Object x509)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ConnectResponse));

            string exampleJson = null;
            exampleJson = "{\n  \"connectionId\" : \"connectionId\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ConnectResponse>(exampleJson)
            : default(ConnectResponse);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Disconnect and destroy the device client
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/destroy")]
        [ValidateModelState]
        [SwaggerOperation("DeviceDestroy")]
        public virtual IActionResult DeviceDestroy([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Disconnect the device
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/disconnect")]
        [ValidateModelState]
        [SwaggerOperation("DeviceDisconnect")]
        public virtual IActionResult DeviceDisconnect([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Disconnect the device
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/disconnect2")]
        [ValidateModelState]
        [SwaggerOperation("DeviceDisconnect2")]
        public virtual IActionResult DeviceDisconnect2([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Enable c2d messages
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/enableC2dMessages")]
        [ValidateModelState]
        [SwaggerOperation("DeviceEnableC2dMessages")]
        public virtual IActionResult DeviceEnableC2dMessages([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Enable methods
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/enableMethods")]
        [ValidateModelState]
        [SwaggerOperation("DeviceEnableMethods")]
        public virtual IActionResult DeviceEnableMethods([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Enable device twins
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/enableTwin")]
        [ValidateModelState]
        [SwaggerOperation("DeviceEnableTwin")]
        public virtual IActionResult DeviceEnableTwin([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// get the current connection status
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/device/{connectionId}/connectionStatus")]
        [ValidateModelState]
        [SwaggerOperation("DeviceGetConnectionStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        public virtual IActionResult DeviceGetConnectionStatus([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            string exampleJson = null;
            exampleJson = "";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get the device twin
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/device/{connectionId}/twin")]
        [ValidateModelState]
        [SwaggerOperation("DeviceGetTwin")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult DeviceGetTwin([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            string exampleJson = null;
            exampleJson = "\"{}\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the device twin
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="props"></param>
        /// <response code="200">OK</response>
        [HttpPatch]
        [Route("/device/{connectionId}/twin")]
        [ValidateModelState]
        [SwaggerOperation("DevicePatchTwin")]
        public virtual IActionResult DevicePatchTwin([FromRoute][Required]string connectionId, [FromBody]Object props)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Reconnect the device
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="forceRenewPassword">True to force SAS renewal</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/reconnect")]
        [ValidateModelState]
        [SwaggerOperation("DeviceReconnect")]
        public virtual IActionResult DeviceReconnect([FromRoute][Required]string connectionId, [FromQuery]bool? forceRenewPassword)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Wait for a method call, verify the request, and return the response.
        /// </summary>
        /// <remarks>This is a workaround to deal with SDKs that only have method call operations that are sync.  This function responds to the method with the payload of this function, and then returns the method parameters.  Real-world implemenatations would never do this, but this is the only same way to write our test code right now (because the method handlers for C, Java, and probably Python all return the method response instead of supporting an async method call)</remarks>
        /// <param name="connectionId">Id for the connection</param>
        /// <param name="methodName">name of the method to handle</param>
        /// <param name="requestAndResponse"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/roundtripMethodCall/{methodName}")]
        [ValidateModelState]
        [SwaggerOperation("DeviceRoundtripMethodCall")]
        public virtual IActionResult DeviceRoundtripMethodCall([FromRoute][Required]string connectionId, [FromRoute][Required]string methodName, [FromBody]RoundtripMethodCallBody requestAndResponse)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Send an event
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <param name="eventBody"></param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/device/{connectionId}/event")]
        [ValidateModelState]
        [SwaggerOperation("DeviceSendEvent")]
        public virtual IActionResult DeviceSendEvent([FromRoute][Required]string connectionId, [FromBody]Object eventBody)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Wait for a c2d message
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/device/{connectionId}/c2dMessage")]
        [ValidateModelState]
        [SwaggerOperation("DeviceWaitForC2dMessage")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        public virtual IActionResult DeviceWaitForC2dMessage([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            string exampleJson = null;
            exampleJson = "";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// wait for the current connection status to change and return the changed status
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/device/{connectionId}/connectionStatusChange")]
        [ValidateModelState]
        [SwaggerOperation("DeviceWaitForConnectionStatusChange")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        public virtual IActionResult DeviceWaitForConnectionStatusChange([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            string exampleJson = null;
            exampleJson = "";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<string>(exampleJson)
            : default(string);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Wait for the next desired property patch
        /// </summary>

        /// <param name="connectionId">Id for the connection</param>
        /// <response code="200">OK</response>
        [HttpGet]
        [Route("/device/{connectionId}/twinDesiredPropPatch")]
        [ValidateModelState]
        [SwaggerOperation("DeviceWaitForDesiredPropertiesPatch")]
        [SwaggerResponse(statusCode: 200, type: typeof(Object), description: "OK")]
        public virtual IActionResult DeviceWaitForDesiredPropertiesPatch([FromRoute][Required]string connectionId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            string exampleJson = null;
            exampleJson = "\"{}\"";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
