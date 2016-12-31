using Abp.Web.Mvc.Views;

namespace biewj.Web.Views
{
    public abstract class biewjWebViewPageBase : biewjWebViewPageBase<dynamic>
    {

    }

    public abstract class biewjWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected biewjWebViewPageBase()
        {
            LocalizationSourceName = biewjConsts.LocalizationSourceName;
        }
    }
}