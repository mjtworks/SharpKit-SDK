//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region JsonP
    /// <inheritdocs />
    /// <summary>
    /// <p>This class is used to create JSONP requests. JSONP is a mechanism that allows for making
    /// requests for data cross domain. More information is available <i>here</i>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class JsonP : Ext.Base
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        private static JsString @className{get;set;}
        /// <summary>
        /// Specifies the GET parameter that will be sent to the server containing the function name to be executed when
        /// the request completes. Defaults to callback. Thus, a common request will be in the form of
        /// url?callback=Ext.data.JsonP.callback1
        /// Defaults to: <c>&quot;callback&quot;</c>
        /// </summary>
        public static JsString callbackKey{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject configMap{get;set;}
        /// <summary>
        /// True to add a unique cache-buster param to requests. Defaults to true.
        /// Defaults to: <c>true</c>
        /// </summary>
        public static bool disableCaching{get;set;}
        /// <summary>
        /// Change the parameter which is sent went disabling caching through a cache buster. Defaults to '_dc'.
        /// Defaults to: <c>&quot;_dc&quot;</c>
        /// </summary>
        public static JsString disableCachingParam{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        private static JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        private static bool isInstance{get;set;}
        /// <summary>
        /// Number of requests done so far.
        /// Defaults to: <c>0</c>
        /// </summary>
        private static JsNumber requestCount{get;set;}
        /// <summary>
        /// Hash of pending requests.
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject requests{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        protected static Class self{get;set;}
        /// <summary>
        /// A default timeout for any JsonP requests. If the request has not completed in this time the
        /// failure callback will be fired. The timeout is in ms. Defaults to 30000.
        /// Defaults to: <c>30000</c>
        /// </summary>
        public static JsNumber timeout{get;set;}
        /// <summary>
        /// Abort a request. If the request parameter is not specified all open requests will
        /// be aborted.
        /// </summary>
        /// <param name="request"><p>The request to abort</p>
        /// </param>
        public static void abort(object request=null){}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// Cleans up anu script handling errors
        /// </summary>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void cleanupErrorHandling(object request){}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Create the script tag given the specified url, params and options. The options
        /// parameter is passed to allow an override to access it.
        /// </summary>
        /// <param name="url"><p>The url of the request</p>
        /// </param>
        /// <param name="params"><p>Any extra params to be sent</p>
        /// </param>
        /// <param name="options"><p>The object passed to <see cref="Ext.data.JsonP.request">request</see>.</p>
        /// </param>
        private static void createScript(JsString url, object @params, object options){}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Handles any aborts when loading the script
        /// </summary>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void handleAbort(object request){}
        /// <summary>
        /// Handles any script errors when loading the script
        /// </summary>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void handleError(object request){}
        /// <summary>
        /// Handle a successful response
        /// </summary>
        /// <param name="result"><p>The result from the request</p>
        /// </param>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void handleResponse(object result, object request){}
        /// <summary>
        /// Handle any script timeouts
        /// </summary>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void handleTimeout(object request){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Loads the script for the given request by appending it to the HEAD element. This is
        /// its own method so that users can override it (as well as createScript).
        /// </summary>
        /// <param name="request"><p>The request object.</p>
        /// </param>
        private static void loadScript(object request){}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Makes a JSONP request.
        /// </summary>
        /// <param name="options"><p>An object which may contain the following properties. Note that options will
        /// take priority over any defaults that are specified in the class.</p>
        /// <ul>
        /// <li><b>url</b> : String <div>The URL to request.</div></li>
        /// <li><b>params</b> : Object (Optional)<div>An object containing a series of
        /// key value pairs that will be sent along with the request.</div></li>
        /// <li><b>timeout</b> : Number (Optional) <div>See <see cref="Ext.data.JsonP.timeout">timeout</see></div></li>
        /// <li><b>callbackKey</b> : String (Optional) <div>See <see cref="Ext.data.JsonP.callbackKey">callbackKey</see></div></li>
        /// <li><b>callbackName</b> : String (Optional) <div>The function name to use for this request.
        /// By default this name will be auto-generated: Ext.data.JsonP.callback1, Ext.data.JsonP.callback2, etc.
        /// Setting this option to "my_name" will force the function name to be <see cref="Ext.data.JsonP">Ext.data.JsonP</see>.my_name.
        /// Use this if you want deterministic behavior, but be careful - the callbackName should be different
        /// in each JsonP request that you make.</div></li>
        /// <li><b>disableCaching</b> : Boolean (Optional) <div>See <see cref="Ext.data.JsonP.disableCaching">disableCaching</see></div></li>
        /// <li><b>disableCachingParam</b> : String (Optional) <div>See <see cref="Ext.data.JsonP.disableCachingParam">disableCachingParam</see></div></li>
        /// <li><b>success</b> : Function (Optional) <div>A function to execute if the request succeeds.</div></li>
        /// <li><b>failure</b> : Function (Optional) <div>A function to execute if the request fails.</div></li>
        /// <li><b>callback</b> : Function (Optional) <div>A function to execute when the request
        /// completes, whether it is a success or failure.</div></li>
        /// <li><b>scope</b> : Object (Optional)<div>The scope in
        /// which to execute the callbacks: The "this" object for the callback function. Defaults to the browser window.</div></li>
        /// </ul>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>request An object containing the request details.</p>
        /// </div>
        /// </returns>
        public static object request(object options=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Sets up error handling for the script
        /// </summary>
        /// <param name="request"><p>The request</p>
        /// </param>
        private static void setupErrorHandling(object request){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        public JsonP(Ext.data.JsonPConfig config){}
        public JsonP(){}
        public JsonP(params object[] args){}
    }
    #endregion
    #region JsonPConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class JsonPConfig : Ext.BaseConfig
    {
        public JsonPConfig(params object[] args){}
    }
    #endregion
    #region JsonPEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class JsonPEvents : Ext.BaseEvents
    {
        public JsonPEvents(params object[] args){}
    }
    #endregion
}
