using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(React_server_side_demo.ReactConfig), "Configure")]

namespace React_server_side_demo
{
    public static class ReactConfig
    {
        public static void Configure()
        {
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();

            ReactSiteConfiguration.Configuration
               .AddScript("~/Scripts/CommentBox/CommentBox.jsx");
        }
    }
}