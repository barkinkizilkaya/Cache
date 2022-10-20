using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace GenericMemoryCache
{
    public class CachingMiddleware
    {
        private RequestDelegate _next;

        public CachingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            string controllerName = context.Request.RouteValues["controller"].ToString();
            string actionName = context.Request.RouteValues["action"].ToString();

            // a try/catch can be added here because you don't want middleware failures to interfere with normal functionality
            var endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
            var attribute = endpoint?.Metadata.GetMetadata<Cacheable>();
            if (attribute != null)
            {
                var ev = attribute.MethodName;
               
            }
            await _next(context); // Here the action in the controller is called
        }
    }
}

