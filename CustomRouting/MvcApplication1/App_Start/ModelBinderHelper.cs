using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.App_Start
{
    public class ModelBinderHelper
    {
        public static string SanitizeQueryStringValue(string value)
        {
            var queryStringValue = value;
            if (queryStringValue != null && queryStringValue.EndsWith("?="))
                queryStringValue = queryStringValue.Replace("?=", "");
            return queryStringValue;
        }
    }
}