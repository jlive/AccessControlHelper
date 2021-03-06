﻿#if NET45
using System.Web;
using System.Web.Mvc;
#else

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

#endif

namespace WeihanLi.AspNetMvc.AccessControlHelper
{
    /// <summary>
    /// Action显示策略
    /// </summary>
    public interface IActionAccessStrategy
    {
        /// <summary>
        /// 是否可以显示
        /// </summary>
        /// <param name="httpContext">httpContext</param>
        /// <param name="accessKey">accessKey</param>
        /// <returns></returns>
#if NET45
        bool IsActionCanAccess(HttpContextBase httpContext, string accessKey);
#else

        bool IsActionCanAccess(HttpContext httpContext, string accessKey);

#endif

        /// <summary>
        /// 默认HTTP请求不被授权时返回的结果
        /// </summary>
#if NET45
        ActionResult DisallowedCommonResult { get; }
#else
        IActionResult DisallowedCommonResult { get; }
#endif

        /// <summary>
        /// Ajax请求不被授权时返回的结果
        /// </summary>
        JsonResult DisallowedAjaxResult { get; }
    }
}