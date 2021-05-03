using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using BackEnd.Extensions;
using BackEnd.Interfaces;
using System;

namespace BackEnd.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //TODO Make loging activity more complete.
            var resultContex = await next();
            if(!resultContex.HttpContext.User.Identity.IsAuthenticated) return;
            var userId = resultContex.HttpContext.User.GetUserId();
            var repo = resultContex.HttpContext.RequestServices.GetService<IUserRepository>();        
            var user = await repo.GetUserByIdAsync(userId);
            System.Diagnostics.Debug.WriteLine(userId);
            user.LastActive = DateTime.Now;
            await repo.SaveAllAsync(); 
        }
    }
}