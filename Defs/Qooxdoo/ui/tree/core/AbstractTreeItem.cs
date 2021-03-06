// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.tree.core
{
    /// <summary>
	/// <para>The AbstractTreeItem serves as a common superclass for the {@link
	/// qx.ui.tree.TreeFile} and <see cref="qx.ui.tree.TreeFolder"/> classes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tree.core.AbstractTreeItem", OmitOptionalParameters = true, Export = false)]
    public abstract partial class AbstractTreeItem : qx.ui.tree.core.AbstractItem
    {
		#region Properties

		/// <summary>
		/// <para>The parent tree folder.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "parent", NativeField = true)]
		public qx.ui.tree.core.AbstractTreeItem Parent { get; set; }

		#endregion Properties

		#region Methods

		public AbstractTreeItem() { throw new NotImplementedException(); }

		public AbstractTreeItem(object label) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds the passed tree items to the end of this item&#8217;s children list.</para>
		/// </summary>
		/// <param name="varargs">variable number of tree items to add</param>
		[JsMethod(Name = "add")]
		public void Add(AbstractTreeItem varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a tree item to this item after the existing child before.</para>
		/// </summary>
		/// <param name="treeItem">tree item to add</param>
		/// <param name="after">existing child to add the item after</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(AbstractTreeItem treeItem, AbstractTreeItem after) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds the tree item to the current item, at the given index.</para>
		/// </summary>
		/// <param name="treeItem">new tree item to insert</param>
		/// <param name="index">position to insert into</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(AbstractTreeItem treeItem, double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a tree item as the first child of this item.</para>
		/// </summary>
		/// <param name="treeItem">tree item to add</param>
		[JsMethod(Name = "addAtBegin")]
		public void AddAtBegin(AbstractTreeItem treeItem) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a tree item to this item before the existing child before.</para>
		/// </summary>
		/// <param name="treeItem">tree item to add</param>
		/// <param name="before">existing child to add the item before</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(AbstractTreeItem treeItem, AbstractTreeItem before) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets a state.</para>
		/// </summary>
		/// <param name="state">The state to add</param>
		[JsMethod(Name = "addState")]
		public void AddState(string state) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get all child items.</para>
		/// <para>Note: Don not modify the returned array, since this function does not
		/// return a copy!</para>
		/// </summary>
		/// <returns>An array of all child items.</returns>
		[JsMethod(Name = "getChildren")]
		public AbstractTreeItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the widget, which acts as container for the child items.
		/// This widget must have a vertical box layout.</para>
		/// </summary>
		/// <returns>The children container</returns>
		[JsMethod(Name = "getChildrenContainer")]
		public qx.ui.core.Widget GetChildrenContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns all children of the folder.</para>
		/// </summary>
		/// <param name="recursive">whether children of subfolder should be included</param>
		/// <param name="invisible">whether invisible children should be included</param>
		/// <param name="ignoreFirst">Whether the current treeItem should be excluded from the list.</param>
		/// <returns>list of children</returns>
		[JsMethod(Name = "getItems")]
		public AbstractTreeItem GetItems(bool recursive = true, bool invisible = true, bool ignoreFirst = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the item&#8217;s nesting level. If the item is not part of a tree
		/// this function will return null.</para>
		/// </summary>
		/// <returns>The item&#8217;s nesting level or null.</returns>
		[JsMethod(Name = "getLevel")]
		public double GetLevel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property parent.</para>
		/// </summary>
		[JsMethod(Name = "getParent")]
		public qx.ui.tree.core.AbstractTreeItem GetParent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the children container of the item&#8217;s parent. This function will return
		/// null, if the item does not have a parent or is not the root
		/// item.</para>
		/// </summary>
		/// <returns>The parent&#8217;s children container.</returns>
		[JsMethod(Name = "getParentChildrenContainer")]
		public qx.ui.core.Widget GetParentChildrenContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the tree the tree item is connected to. If the item is not part of
		/// a tree null will be returned.</para>
		/// </summary>
		/// <returns>The item&#8217;s tree or null.</returns>
		[JsMethod(Name = "getTree")]
		public qx.ui.tree.Tree GetTree() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the item has any children</para>
		/// </summary>
		/// <returns>Whether the item has any children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the tree item has a children container</para>
		/// </summary>
		/// <returns>Whether it has a children container</returns>
		[JsMethod(Name = "hasChildrenContainer")]
		public bool HasChildrenContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property parent
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property parent.</param>
		[JsMethod(Name = "initParent")]
		public void InitParent(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the passed tree items from this item.</para>
		/// </summary>
		/// <param name="varargs">variable number of tree items to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(AbstractTreeItem varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all child items from this item.</para>
		/// </summary>
		[JsMethod(Name = "removeAll")]
		public void RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the child with the given child index.</para>
		/// </summary>
		/// <param name="index">Index of the child to remove</param>
		[JsMethod(Name = "removeAt")]
		public void RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears a state.</para>
		/// </summary>
		/// <param name="state">the state to clear.</param>
		[JsMethod(Name = "removeState")]
		public void RemoveState(string state) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property parent.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetParent")]
		public void ResetParent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property parent.</para>
		/// </summary>
		/// <param name="value">New value for property parent.</param>
		[JsMethod(Name = "setParent")]
		public void SetParent(qx.ui.tree.core.AbstractTreeItem value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}