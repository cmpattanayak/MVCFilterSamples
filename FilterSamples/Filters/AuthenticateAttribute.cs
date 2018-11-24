using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FilterSamples.Filters
{
    public class AuthenticateAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        private bool _auth;
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            _auth = (filterContext.ActionDescriptor.GetCustomAttributes(typeof(OverrideAuthenticationAttribute), true)).Length == 0;
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var user = HttpContext.Current.User;

            if (user == null || !user.Identity.IsAuthenticated)
                filterContext.Result = new HttpUnauthorizedResult();
        }
    }
}