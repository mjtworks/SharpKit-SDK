// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.control
{
    /// <summary>
	/// <para>A typical color selector as known from native applications.</para>
	/// <para>Includes support for RGB and HSB color areas.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.control.ColorSelector", OmitOptionalParameters = true, Export = false)]
    public partial class ColorSelector : qx.ui.core.Widget, qx.ui.form.IColorForm
    {
		#region Events

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>Fired when the &#8220;Cancel&#8221; button is clicked.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnDialogcancel;

		/// <summary>
		/// <para>Fired when the &#8220;OK&#8221; button is clicked.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnDialogok;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>The numeric blue value of the selected color.</para>
		/// </summary>
		[JsProperty(Name = "blue", NativeField = true)]
		public double Blue { get; set; }

		/// <summary>
		/// <para>The numeric brightness value.</para>
		/// </summary>
		[JsProperty(Name = "brightness", NativeField = true)]
		public double Brightness { get; set; }

		/// <summary>
		/// <para>The numeric green value of the selected color.</para>
		/// </summary>
		[JsProperty(Name = "green", NativeField = true)]
		public double Green { get; set; }

		/// <summary>
		/// <para>The numeric hue value.</para>
		/// </summary>
		[JsProperty(Name = "hue", NativeField = true)]
		public double Hue { get; set; }

		/// <summary>
		/// <para>The numeric red value of the selected color.</para>
		/// </summary>
		[JsProperty(Name = "red", NativeField = true)]
		public double Red { get; set; }

		/// <summary>
		/// <para>The numeric saturation value.</para>
		/// </summary>
		[JsProperty(Name = "saturation", NativeField = true)]
		public double Saturation { get; set; }

		#endregion Properties

		#region Methods

		/// <summary>
		/// <para>Creates a ColorSelector.</para>
		/// </summary>
		public ColorSelector() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blue.</para>
		/// </summary>
		[JsMethod(Name = "getBlue")]
		public double GetBlue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property brightness.</para>
		/// </summary>
		[JsMethod(Name = "getBrightness")]
		public double GetBrightness() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property green.</para>
		/// </summary>
		[JsMethod(Name = "getGreen")]
		public double GetGreen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property hue.</para>
		/// </summary>
		[JsMethod(Name = "getHue")]
		public double GetHue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property red.</para>
		/// </summary>
		[JsMethod(Name = "getRed")]
		public double GetRed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property saturation.</para>
		/// </summary>
		[JsMethod(Name = "getSaturation")]
		public double GetSaturation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blue
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blue.</param>
		[JsMethod(Name = "initBlue")]
		public void InitBlue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property brightness
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property brightness.</param>
		[JsMethod(Name = "initBrightness")]
		public void InitBrightness(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property green
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property green.</param>
		[JsMethod(Name = "initGreen")]
		public void InitGreen(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property hue
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property hue.</param>
		[JsMethod(Name = "initHue")]
		public void InitHue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property red
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property red.</param>
		[JsMethod(Name = "initRed")]
		public void InitRed(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property saturation
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property saturation.</param>
		[JsMethod(Name = "initSaturation")]
		public void InitSaturation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blue.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlue")]
		public void ResetBlue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property brightness.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBrightness")]
		public void ResetBrightness() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property green.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGreen")]
		public void ResetGreen() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property hue.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetHue")]
		public void ResetHue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property red.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRed")]
		public void ResetRed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property saturation.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSaturation")]
		public void ResetSaturation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blue.</para>
		/// </summary>
		/// <param name="value">New value for property blue.</param>
		[JsMethod(Name = "setBlue")]
		public void SetBlue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property brightness.</para>
		/// </summary>
		/// <param name="value">New value for property brightness.</param>
		[JsMethod(Name = "setBrightness")]
		public void SetBrightness(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property green.</para>
		/// </summary>
		/// <param name="value">New value for property green.</param>
		[JsMethod(Name = "setGreen")]
		public void SetGreen(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property hue.</para>
		/// </summary>
		/// <param name="value">New value for property hue.</param>
		[JsMethod(Name = "setHue")]
		public void SetHue(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets previous color&#8217;s to given values.</para>
		/// </summary>
		/// <param name="red">Red color value.</param>
		/// <param name="green">Green color value.</param>
		/// <param name="blue">Blue color value.</param>
		[JsMethod(Name = "setPreviousColor")]
		public void SetPreviousColor(double red, double green, double blue) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property red.</para>
		/// </summary>
		/// <param name="value">New value for property red.</param>
		[JsMethod(Name = "setRed")]
		public void SetRed(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property saturation.</para>
		/// </summary>
		/// <param name="value">New value for property saturation.</param>
		[JsMethod(Name = "setSaturation")]
		public void SetSaturation(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}