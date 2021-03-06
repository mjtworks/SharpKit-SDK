//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout
{
    #region Layout
    /// <inheritdocs />
    /// <summary>
    /// <p>Base Layout class - extended by ComponentLayout and ContainerLayout</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Layout : Ext.Base
    {
        /// <summary>
        /// Used only during a layout run, this value indicates that a
        /// layout has finished its calculations. This flag is set to true prior to the call to
        /// calculate and should be set to false if this layout has more work to do.
        /// </summary>
        public bool done{get;set;}
        /// <summary>
        /// true in this class to identify an object as an instantiated Layout, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isLayout{get;set;}
        /// <summary>
        /// Removes layout's itemCls and owning Container's itemCls.
        /// Clears the managed dimensions flags
        /// </summary>
        /// <param name="item">
        /// </param>
        protected void afterRemove(object item){}
        /// <summary>
        /// Called before any calculation cycles to prepare for layout.
        /// This is a write phase and DOM reads should be strictly avoided when overridding
        /// this method.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void beginLayout(ContextItem ownerContext){}
        /// <summary>
        /// Called before any calculation cycles to reset DOM values and prepare for calculation.
        /// This is a write phase and DOM reads should be strictly avoided when overridding
        /// this method.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void beginLayoutCycle(ContextItem ownerContext){}
        /// <summary>
        /// Called to perform the calculations for this layout. This method will be called at
        /// least once and may be called repeatedly if the done property is cleared
        /// before return to indicate that this layout is not yet done. The done property
        /// is always set to true before entering this method.
        /// This is a read phase and DOM writes should be strictly avoided in derived classes.
        /// Instead, DOM writes need to be written to <see cref="Ext.layout.ContextItem">Ext.layout.ContextItem</see> objects to
        /// be flushed at the next opportunity.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void calculate(ContextItem ownerContext){}
        /// <summary>
        /// This method (if implemented) is called at the end of the cycle in which this layout
        /// completes (by not setting done to false in calculate). It is
        /// possible for the layout to complete and yet become invalid before the end of the cycle,
        /// in which case, this method will not be called. It is also possible for this method to
        /// be called and then later the layout becomes invalidated. This will result in
        /// calculate being called again, followed by another call to this method.
        /// This is a read phase and DOM writes should be strictly avoided in derived classes.
        /// Instead, DOM writes need to be written to <see cref="Ext.layout.ContextItem">Ext.layout.ContextItem</see> objects to
        /// be flushed at the next opportunity.
        /// This method need not be implemented by derived classes and, in fact, should only be
        /// implemented when needed.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void completeLayout(ContextItem ownerContext){}
        /// <summary>
        /// Called before an item is rendered to allow the layout to configure the item.
        /// </summary>
        /// <param name="item"><p>The item to be configured</p>
        /// </param>
        protected void configureItem(Ext.Component item){}
        /// <summary>
        /// This method (if implemented) is called after all layouts have completed. In most
        /// ways this is similar to completeLayout. This call can cause this (or any
        /// layout) to be become invalid (see Ext.layout.Context.invalidate), but this
        /// is best avoided. This method is intended to be where final reads are made and so it
        /// is best to avoid invalidating layouts at this point whenever possible. Even so, this
        /// method can be used to perform final checks that may require all other layouts to be
        /// complete and then invalidate some results.
        /// This is a read phase and DOM writes should be strictly avoided in derived classes.
        /// Instead, DOM writes need to be written to <see cref="Ext.layout.ContextItem">Ext.layout.ContextItem</see> objects to
        /// be flushed at the next opportunity.
        /// This method need not be implemented by derived classes and, in fact, should only be
        /// implemented when needed.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void finalizeLayout(ContextItem ownerContext){}
        /// <summary>
        /// This method is called after all layouts are complete and their calculations flushed
        /// to the DOM. No further layouts will be run and this method is only called once per
        /// layout run. The base component layout caches lastComponentSize.
        /// This is a write phase and DOM reads should be avoided if possible when overridding
        /// this method.
        /// This method need not be implemented by derived classes and, in fact, should only be
        /// implemented when needed.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void finishedLayout(ContextItem ownerContext){}
        /// <summary>
        /// Returns an object describing how this layout manages the size of the given component.
        /// This method must be implemented by any layout that manages components.
        /// </summary>
        /// <param name="item">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>An object describing the sizing done by the layout for this item or
        /// null if the layout mimics the size policy of its ownerCt (e.g., 'fit' and 'card').</p>
        /// <ul><li><span>readsWidth</span> : <see cref="bool">Boolean</see><div><p>True if the natural/auto width of this component
        /// is used by the ownerLayout.</p>
        /// </div></li><li><span>readsHeight</span> : <see cref="bool">Boolean</see><div><p>True if the natural/auto height of this component
        /// is used by the ownerLayout.</p>
        /// </div></li><li><span>setsWidth</span> : <see cref="bool">Boolean</see><div><p>True if the ownerLayout set this component's width.</p>
        /// </div></li><li><span>setsHeight</span> : <see cref="bool">Boolean</see><div><p>True if the ownerLayout set this component's height.</p>
        /// </div></li></ul></div>
        /// </returns>
        protected object getItemSizePolicy(Ext.Component item){return null;}
        /// <summary>
        /// Returns the set of items to layout (empty by default).
        /// </summary>
        protected void getLayoutItems(){}
        /// <summary>
        /// A one-time initialization method called just before rendering.
        /// </summary>
        protected void initLayout(){}
        /// <summary>
        /// Validates item is in the proper place in the dom.
        /// </summary>
        /// <param name="item">
        /// </param>
        /// <param name="target">
        /// </param>
        /// <param name="position">
        /// </param>
        protected void isValidParent(object item, object target, object position){}
        /// <summary>
        /// Moves Component to the provided target instead.
        /// </summary>
        /// <param name="item">
        /// </param>
        /// <param name="target">
        /// </param>
        /// <param name="position">
        /// </param>
        private void moveItem(object item, object target, object position){}
        /// <summary>
        /// This method (if implemented) is called after all layouts are finished, and all have
        /// a lastComponentSize cached. No further layouts will be run and this method is only
        /// called once per layout run. It is the bookend to beginLayout.
        /// This is a write phase and DOM reads should be avoided if possible when overridding
        /// this method. This is the catch-all tail method to a layout and so the rules are more
        /// relaxed. Even so, for performance reasons, it is best to avoid reading the DOM. If
        /// a read is necessary, consider implementing a <see cref="Ext.layout.Layout.finalizeLayout">finalizeLayout</see> method to do the
        /// required reads.
        /// This method need not be implemented by derived classes and, in fact, should only be
        /// implemented when needed.
        /// </summary>
        /// <param name="ownerContext"><p>The context item for the layout's owner
        /// component.</p>
        /// </param>
        public void notifyOwner(ContextItem ownerContext){}
        /// <summary>
        /// This method is called when a child item changes in some way. By default this calls
        /// Ext.AbstractComponent.updateLayout on this layout's owner.
        /// </summary>
        /// <param name="child"><p>The child item that has changed.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this layout has handled the content change.</p>
        /// </div>
        /// </returns>
        public bool onContentChange(Ext.Component child){return false;}
        /// <summary>
        /// Renders the given Component into the target Element.
        /// </summary>
        /// <param name="item"><p>The Component to render</p>
        /// </param>
        /// <param name="target"><p>The target Element</p>
        /// </param>
        /// <param name="position"><p>The position within the target to render the item to</p>
        /// </param>
        private void renderItem(Ext.Component item, Ext.dom.Element target, JsNumber position){}
        /// <summary>
        /// Iterates over all passed items, ensuring they are rendered.  If the items are already rendered,
        /// also determines if the items are in the proper place in the dom.
        /// </summary>
        /// <param name="items">
        /// </param>
        /// <param name="target">
        /// </param>
        protected void renderItems(object items, object target){}
        public Layout(LayoutConfig config){}
        public Layout(){}
        public Layout(params object[] args){}
    }
    #endregion
    #region LayoutConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LayoutConfig : Ext.BaseConfig
    {
        public LayoutConfig(params object[] args){}
    }
    #endregion
    #region LayoutEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LayoutEvents : Ext.BaseEvents
    {
        public LayoutEvents(params object[] args){}
    }
    #endregion
}
