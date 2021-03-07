using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Core.Extensions;
using Business.Constants;

namespace Business.BusinessAspects.Autofac
{
    //for JWT
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');//("product.add,admin") iki elemanlı dizi haline gelir
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();//injection değerlerini alacak

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))//claimlerin içinde ilgili rol varsa
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);//yetkin yok hatası ver
        }
    }
}
