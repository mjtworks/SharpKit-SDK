// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data
{
    /// <summary>
	/// <para>This class offers a set of default conversion methods and whole options
	/// packs for <see cref="qx.data.SingleValueBinding"/>. The binding offers a conversion
	/// itself if it can determinate which types should be used. In all other cases,
	/// you can you this methods / options for the default conversion.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.Conversion", OmitOptionalParameters = true, Export = false)]
    public partial class Conversion 
    {
		#region Methods

		public Conversion() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts the given value to a boolean via !!value.</para>
		/// </summary>
		/// <param name="value">The value to convert.</param>
		/// <returns>The converted value.</returns>
		[JsMethod(Name = "toBoolean")]
		public static bool ToBoolean(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts the given value to a number via parseFloat.</para>
		/// </summary>
		/// <param name="value">The value to convert.</param>
		/// <returns>The converted value.</returns>
		[JsMethod(Name = "toNumber")]
		public static double ToNumber(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts the given value to a string via  + &#8221;&#8221;.</para>
		/// </summary>
		/// <param name="value">The value to convert.</param>
		/// <returns>The converted value.</returns>
		[JsMethod(Name = "toString")]
		public static string ToString(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}