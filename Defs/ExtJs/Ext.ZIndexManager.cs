//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region ZIndexManager
    /// <inheritdocs />
    /// <summary>
    /// <p>A class that manages a group of <see cref="Ext.ComponentConfig.floating">Ext.Component.floating</see> Components and provides z-order management,
    /// and Component activation behavior, including masking below the active (topmost) Component.</p>
    /// <p><see cref="Ext.ComponentConfig.floating">Floating</see> Components which are rendered directly into the document (such as
    /// <see cref="Ext.window.Window">Window</see>s) which are <see cref="Ext.Component.show">show</see>n are managed by a
    /// <see cref="Ext.WindowManager">global instance</see>.</p>
    /// <p><see cref="Ext.ComponentConfig.floating">Floating</see> Components which are descendants of <see cref="Ext.ComponentConfig.floating">floating</see>
    /// <em>Containers</em> (for example a <see cref="Ext.view.BoundList">BoundList</see> within an <see cref="Ext.window.Window">Window</see>,
    /// or a <see cref="Ext.menu.Menu">Menu</see>), are managed by a ZIndexManager owned by that floating Container. Therefore
    /// ComboBox dropdowns within Windows will have managed z-indices guaranteed to be correct, relative to the Window.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ZIndexManager : Ext.Base
    {
        /// <summary>
        /// Brings the specified Component to the front of any other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="comp"><p>The id of the Component or a <see cref="Ext.Component">Ext.Component</see> instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the dialog was brought to the front, else false
        /// if it was already in front</p>
        /// </div>
        /// </returns>
        public bool bringToFront(object comp){return false;}
        /// <summary>
        /// Executes the specified function once for every Component in this ZIndexManager, passing each
        /// Component as the only parameter. Returning false from the function will stop the iteration.
        /// </summary>
        /// <param name="fn"><p>The function to execute for each item</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function
        /// is executed. Defaults to the current Component in the iteration.</p>
        /// </param>
        public void each(System.Delegate fn, object scope=null){}
        /// <summary>
        /// Executes the specified function once for every Component in this ZIndexManager, passing each
        /// Component as the only parameter. Returning false from the function will stop the iteration.
        /// The components are passed to the function starting at the bottom and proceeding to the top.
        /// </summary>
        /// <param name="fn"><p>The function to execute for each item</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function
        /// is executed. Defaults to the current Component in the iteration.</p>
        /// </param>
        public void eachBottomUp(System.Delegate fn, object scope=null){}
        /// <summary>
        /// Executes the specified function once for every Component in this ZIndexManager, passing each
        /// Component as the only parameter. Returning false from the function will stop the iteration.
        /// The components are passed to the function starting at the top and proceeding to the bottom.
        /// </summary>
        /// <param name="fn"><p>The function to execute for each item</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function
        /// is executed. Defaults to the current Component in the iteration.</p>
        /// </param>
        public void eachTopDown(System.Delegate fn, object scope=null){}
        /// <summary>
        /// Gets a registered Component by id.
        /// </summary>
        /// <param name="id"><p>The id of the Component or a <see cref="Ext.Component">Ext.Component</see> instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div>
        /// </div>
        /// </returns>
        public Ext.Component get(object id){return null;}
        /// <summary>
        /// Gets the currently-active Component in this ZIndexManager.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>The active Component</p>
        /// </div>
        /// </returns>
        public Ext.Component getActive(){return null;}
        /// <summary>
        /// Returns zero or more Components in this ZIndexManager using the custom search function passed to this method.
        /// The function should accept a single Ext.Component reference as its only argument and should
        /// return true if the Component matches the search criteria, otherwise it should return false.
        /// </summary>
        /// <param name="fn"><p>The search function</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed.
        /// Defaults to the Component being tested. That gets passed to the function if not specified.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div><p>An array of zero or more matching windows</p>
        /// </div>
        /// </returns>
        public JsArray getBy(System.Delegate fn, object scope=null){return null;}
        /// <summary>
        /// Temporarily hides all currently visible managed Components. This is for when
        /// dragging a Window which may manage a set of floating descendants in its ZIndexManager;
        /// they should all be hidden just for the duration of the drag.
        /// </summary>
        private void hide(){}
        /// <summary>
        /// Hides all Components managed by this ZIndexManager.
        /// </summary>
        public void hideAll(){}
        /// <summary>
        /// Registers a floating Ext.Component with this ZIndexManager. This should not
        /// need to be called under normal circumstances. Floating Components (such as Windows,
        /// BoundLists and Menus) are automatically registered with a
        /// zIndexManager at render time.
        /// Where this may be useful is moving Windows between two ZIndexManagers. For example,
        /// to bring the <see cref="Ext.MessageBox">Ext.MessageBox</see> dialog under the same manager as the Desktop's
        /// ZIndexManager in the desktop sample app:
        /// <code>MyDesktop.getDesktop().getManager().register(<see cref="Ext.MessageBox">Ext.MessageBox</see>);
        /// </code>
        /// </summary>
        /// <param name="comp"><p>The Component to register.</p>
        /// </param>
        public void register(Ext.Component comp){}
        /// <summary>
        /// Sends the specified Component to the back of other active Components in this ZIndexManager.
        /// </summary>
        /// <param name="comp"><p>The id of the Component or a <see cref="Ext.Component">Ext.Component</see> instance</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>The Component</p>
        /// </div>
        /// </returns>
        public Ext.Component sendToBack(object comp){return null;}
        /// <summary>
        /// Restores temporarily hidden managed Components to visibility.
        /// </summary>
        private void show(){}
        /// <summary>
        /// Unregisters a Ext.Component from this ZIndexManager. This should not
        /// need to be called. Components are automatically unregistered upon destruction.
        /// See register.
        /// </summary>
        /// <param name="comp"><p>The Component to unregister.</p>
        /// </param>
        public void unregister(Ext.Component comp){}
        public ZIndexManager(ZIndexManagerConfig config){}
        public ZIndexManager(){}
        public ZIndexManager(params object[] args){}
    }
    #endregion
    #region ZIndexManagerConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ZIndexManagerConfig : Ext.BaseConfig
    {
        public ZIndexManagerConfig(params object[] args){}
    }
    #endregion
    #region ZIndexManagerEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ZIndexManagerEvents : Ext.BaseEvents
    {
        public ZIndexManagerEvents(params object[] args){}
    }
    #endregion
}
