// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.rowrenderer
{
    /// <summary>
	/// <para>The default data row renderer.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.rowrenderer.Default", OmitOptionalParameters = true, Export = false)]
    public partial class Default : qx.core.Object, qx.ui.table.IRowRenderer
    {
		#region Properties

		/// <summary>
		/// <para>Whether the focused row should be highlighted.</para>
		/// </summary>
		[JsProperty(Name = "highlightFocusRow", NativeField = true)]
		public bool HighlightFocusRow { get; set; }

		#endregion Properties

		#region Methods

		public Default() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a style string, which will be set as the style property of the row.</para>
		/// </summary>
		/// <param name="rowInfo">A map containing the information about the row to update. See #updateDataRowElement for more information.</param>
		[JsMethod(Name = "createRowStyle")]
		public void CreateRowStyle(object rowInfo) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property highlightFocusRow.</para>
		/// </summary>
		[JsMethod(Name = "getHighlightFocusRow")]
		public bool GetHighlightFocusRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add extra attributes to each row.</para>
		/// </summary>
		/// <param name="rowInfo">The following members are available in rowInfo:  table {qx.ui.table.Table} The table object  styleHeight {Integer} The height of this (and every) row  row {Integer} The number of the row being added  selected {Boolean} Whether the row being added is currently selected  focusedRow {Boolean} Whether the row being added is currently focused  rowData {Array} The array row from the data model of the row being added </param>
		/// <returns>Any additional attributes and their values that should be added to the div tag for the row.</returns>
		[JsMethod(Name = "getRowAttributes")]
		public string GetRowAttributes(object rowInfo) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a HTML class string, which will be set as the class property of the row.</para>
		/// </summary>
		/// <param name="rowInfo">A map containing the information about the row to update. See #updateDataRowElement for more information.</param>
		[JsMethod(Name = "getRowClass")]
		public void GetRowClass(object rowInfo) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the row&#8217;s height CSS style taking the box model into account</para>
		/// </summary>
		/// <param name="height">The row&#8217;s (border-box) height in pixel</param>
		[JsMethod(Name = "getRowHeightStyle")]
		public void GetRowHeightStyle(double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property highlightFocusRow
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property highlightFocusRow.</param>
		[JsMethod(Name = "initHighlightFocusRow")]
		public void InitHighlightFocusRow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property highlightFocusRow equals true.</para>
		/// </summary>
		[JsMethod(Name = "isHighlightFocusRow")]
		public void IsHighlightFocusRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property highlightFocusRow.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetHighlightFocusRow")]
		public void ResetHighlightFocusRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property highlightFocusRow.</para>
		/// </summary>
		/// <param name="value">New value for property highlightFocusRow.</param>
		[JsMethod(Name = "setHighlightFocusRow")]
		public void SetHighlightFocusRow(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property highlightFocusRow.</para>
		/// </summary>
		[JsMethod(Name = "toggleHighlightFocusRow")]
		public void ToggleHighlightFocusRow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Updates a data row.</para>
		/// <para>The rowInfo map contains the following properties:
		/// <list type="bullet">
		/// <item>rowData (var): contains the row data for the row.
		/// The kind of this object depends on the table model, see
		/// <see cref="ITableModel.GetRowData()"/></item>
		/// <item>row (int): the model index of the row.</item>
		/// <item>selected (boolean): whether a cell in this row is selected.</item>
		/// <item>focusedRow (boolean): whether the focused cell is in this row.</item>
		/// <item>table (qx.ui.table.Table): the table the row belongs to.</item>
		/// </list></para>
		/// </summary>
		/// <param name="rowInfo">A map containing the information about the row to update.</param>
		/// <param name="rowElement">the DOM element that renders the data row.</param>
		[JsMethod(Name = "updateDataRowElement")]
		public void UpdateDataRowElement(object rowInfo, qx.html.Element rowElement) { throw new NotImplementedException(); }

		#endregion Methods
    }
}