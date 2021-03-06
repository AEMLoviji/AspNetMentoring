﻿using Microsoft.AspNetCore.Builder;

namespace Module2.Middlewares
{
    public static class ImageCacheMiddlewareExtension
    {
        public static IApplicationBuilder UseImageCache(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ImageCacheMiddleware>();
        }
    }
}
