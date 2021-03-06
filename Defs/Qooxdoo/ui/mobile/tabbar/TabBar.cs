// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.tabbar
{
    /// <summary>
	/// <para>This widget displays a tab bar.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var tabBar = new qx.ui.mobile.tabbar.TabBar();
	/// var tabButton1 = new qx.ui.mobile.tabbar.TabButton("Tab 1");
	/// tabButton1.setView(view1);
	/// tabBar.add(tabButton1);
	/// var tabButton2 = new qx.ui.mobile.tabbar.TabButton("Tab 2");
	/// tabButton2.setView(view2);
	/// tabBar.add(tabButton2);
	/// this.getRoot.add(tabBar);
	/// </code>
	/// <para>This example creates a tab bar and adds two tab buttons to it.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.tabbar.TabBar", OmitOptionalParameters = true, Export = false)]
    public partial class TabBar : qx.ui.mobile.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Selection"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		/// <summary>
		/// <para>Sets the selected tab.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "selection", NativeField = true)]
		public qx.ui.mobile.tabbar.TabButton Selection { get; set; }

		#endregion Properties

		#region Methods

		public TabBar() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a tab button to the tab bar.</para>
		/// </summary>
		/// <param name="button">The button to add</param>
		[JsMethod(Name = "add")]
		public void Add(qx.ui.mobile.tabbar.TabButton button) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selection.</para>
		/// </summary>
		[JsMethod(Name = "getSelection")]
		public qx.ui.mobile.tabbar.TabButton GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selection.</param>
		[JsMethod(Name = "initSelection")]
		public void InitSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a tab button from the tab bar.</para>
		/// </summary>
		/// <param name="button">The button to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(qx.ui.mobile.tabbar.TabButton button) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selection.</para>
		/// </summary>
		/// <param name="value">New value for property selection.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.ui.mobile.tabbar.TabButton value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}