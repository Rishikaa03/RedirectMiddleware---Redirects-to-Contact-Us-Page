namespace RedirectMiddleware.Controllers.MiddleWare
{
    public class ProductRedirectMiddleware
    {
        private readonly RequestDelegate _next;
        public ProductRedirectMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Query.ContainsKey("productId") && context.Request.Query["productId"] == "21")
            {
                context.Response.Redirect("contactUs");
            }
            await _next(context);
        }
    }
}
