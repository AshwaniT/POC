using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.ModelBinding;

namespace MvcApplication1.App_Start
{
    public class ShippingAddressSearchModelBinder : IModelBinder
    {
        public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(ShippingAddressSearchModel)) return false;

            var shippingAddressSearchModel = new ShippingAddressSearchModel();
            foreach (var queryNameValuePair in actionContext.Request.GetQueryNameValuePairs())
            {
                var sanitizedQueryValue = ModelBinderHelper.SanitizeQueryStringValue(queryNameValuePair.Value);
                switch (queryNameValuePair.Key)
                {
                    case "Top":
                        shippingAddressSearchModel.Top = sanitizedQueryValue.ToInt();
                        break;
                    case "PageSize":
                        shippingAddressSearchModel.PageSize = sanitizedQueryValue.ToInt();
                        break;
                    case "PageNumber":
                        shippingAddressSearchModel.PageNumber = sanitizedQueryValue.ToInt();
                        break;
                    case "ShowAddressPageNumber":
                        shippingAddressSearchModel.ShowAddressPageNumber = sanitizedQueryValue.ToBoolean();
                        break;
                }
            }
            bindingContext.Model = shippingAddressSearchModel;
            return true;
        }
    }
}