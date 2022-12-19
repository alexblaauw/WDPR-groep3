namespace WDPR
{

    using JavaScriptEngineSwitcher.Core;
    using JavaScriptEngineSwitcher.V8;
    using System.Web.Mvc;

    public static class ReactConfig
    {
        public static void Configure()
        {
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
    }
}
