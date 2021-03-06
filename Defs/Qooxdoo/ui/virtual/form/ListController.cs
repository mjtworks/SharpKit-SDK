// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.form
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>This controller is responsible for bringing a data array like model to
	/// a virtual list.</para>
	/// <para>This code is highly experimental and there will be API changes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.form.ListController", OmitOptionalParameters = true, Export = false)]
    public partial class ListController : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Delegate"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeDelegate;

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		/// <summary>
		/// Fired on change of the property <see cref="Selection"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		/// <summary>
		/// Fired on change of the property <see cref="Target"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeTarget;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Delegation object, which can have one ore more functions defined by the
		/// <see cref="qx.data.controller.IControllerDelegate"/> interface.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		/// <summary>
		/// <para>Data array containing the data which should be shown in the list.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public qx.data.IListData Model { get; set; }

		/// <summary>
		/// <para>Data array containing the selected model objects. This property can be
		/// manipulated directly which means that a push to the selection will also
		/// select the corresponding element in the target.</para>
		/// </summary>
		[JsProperty(Name = "selection", NativeField = true)]
		public qx.data.IListData Selection { get; set; }

		/// <summary>
		/// <para>The target widget which should show the data.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "target", NativeField = true)]
		public qx.ui.virtualx.form.List Target { get; set; }

		#endregion Properties

		#region Methods

		public ListController() { throw new NotImplementedException(); }

		/// <param name="model">The model as array.</param>
		/// <param name="target">The virtual list as target.</param>
		public ListController(qx.data.IListData model, qx.ui.virtualx.form.List target) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Accessor for the row data.</para>
		/// </summary>
		/// <param name="row">The row to access.</param>
		/// <returns>Data for the given row</returns>
		[JsMethod(Name = "getCellData")]
		public object GetCellData(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public qx.data.IListData GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the absolute number of rows.</para>
		/// </summary>
		/// <returns>length of lookup table</returns>
		[JsMethod(Name = "getRowCount")]
		public double GetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selection.</para>
		/// </summary>
		[JsMethod(Name = "getSelection")]
		public qx.data.IListData GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property target.</para>
		/// </summary>
		[JsMethod(Name = "getTarget")]
		public qx.ui.virtualx.form.List GetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selection.</param>
		[JsMethod(Name = "initSelection")]
		public void InitSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property target
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property target.</param>
		[JsMethod(Name = "initTarget")]
		public void InitTarget(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property target.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTarget")]
		public void ResetTarget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(qx.data.IListData value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selection.</para>
		/// </summary>
		/// <param name="value">New value for property selection.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.data.IListData value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property target.</para>
		/// </summary>
		/// <param name="value">New value for property target.</param>
		[JsMethod(Name = "setTarget")]
		public void SetTarget(qx.ui.virtualx.form.List value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Updates the lookup table used for sorting and filtering.</para>
		/// </summary>
		[JsMethod(Name = "update")]
		public void Update() { throw new NotImplementedException(); }

		#endregion Methods
    }
}