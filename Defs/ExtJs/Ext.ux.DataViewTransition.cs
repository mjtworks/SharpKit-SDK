//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux
{
    #region DataViewTransition
    /// <summary>
    /// <p>Transition plugin for DataViews</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DataViewTransition
    {
        /// <summary>
        /// A cache of existing store data, keyed by id. This is used to determine
        /// whether any items were added or removed from the store on data change
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject cachedStoreData{get;set;}
        /// <summary>
        /// Reference to the DataView this instance is bound to
        /// </summary>
        public Ext.view.View dataview{get;set;}
        /// <summary>
        /// The string ID of the DataView component. This is used internally when animating child objects
        /// </summary>
        public JsString dataviewID{get;set;}
        /// <summary>
        /// Default configuration options for all DataViewTransition instances
        /// Defaults to: <c>{duration: 750, idProperty: &quot;id&quot;}</c>
        /// </summary>
        public JsObject defaults{get;set;}
        /// <summary>
        /// Creates the plugin instance, applies defaults
        /// </summary>
        /// <param name="config"><p>Optional config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public DataViewTransition(object config=null){}
        /// <summary>
        /// Caches the records from a store locally for comparison later
        /// </summary>
        /// <param name="store"><p>The store to cache data from</p>
        /// </param>
        public void cacheStoreData(Ext.data.Store store){}
        /// <summary>
        /// Returns all records in the given store that were not already present
        /// </summary>
        /// <param name="store"><p>The updated store instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Object of records not already present in the dataview in format {id: record}</p>
        /// </div>
        /// </returns>
        public object getAdded(Ext.data.Store store){return null;}
        /// <summary>
        /// Returns all records that were already in the DataView
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>All existing records</p>
        /// </div>
        /// </returns>
        public object getExisting(){return null;}
        /// <summary>
        /// Returns the total number of items that are currently visible in the DataView
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The number of existing items</p>
        /// </div>
        /// </returns>
        public JsNumber getExistingCount(){return null;}
        /// <summary>
        /// Returns all records that are already present and are still present in the new store
        /// </summary>
        /// <param name="store"><p>The updated store instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Object of records that are still present from last time in format {id: record}</p>
        /// </div>
        /// </returns>
        public object getRemaining(Ext.data.Store store){return null;}
        /// <summary>
        /// Returns all records that are present in the DataView but not the new store
        /// </summary>
        /// <param name="store"><p>The updated store instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div><p>Array of records that used to be present</p>
        /// </div>
        /// </returns>
        public JsArray getRemoved(Ext.data.Store store){return null;}
        /// <summary>
        /// Initializes the transition plugin. Overrides the dataview's default refresh function
        /// </summary>
        /// <param name="dataview"><p>The dataview</p>
        /// </param>
        public void init(Ext.view.View dataview){}
        public DataViewTransition(DataViewTransitionConfig config){}
        public DataViewTransition(params object[] args){}
    }
    #endregion
    #region DataViewTransitionConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DataViewTransitionConfig
    {
        public DataViewTransitionConfig(params object[] args){}
    }
    #endregion
    #region DataViewTransitionEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DataViewTransitionEvents
    {
        public DataViewTransitionEvents(params object[] args){}
    }
    #endregion
}
