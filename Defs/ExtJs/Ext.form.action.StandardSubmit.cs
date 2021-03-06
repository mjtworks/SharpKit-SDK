//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.action
{
    #region StandardSubmit
    /// <inheritdocs />
    /// <summary>
    /// <p>A class which handles submission of data from <see cref="Ext.form.Basic">Form</see>s using a standard <c>&lt;form&gt;</c> element submit.
    /// It does not handle the response from the submit.</p>
    /// <p>If validation of the form fields fails, the Form's afterAction method will be called. Otherwise, afterAction will not
    /// be called.</p>
    /// <p>Instances of this class are only created by a <see cref="Ext.form.Basic">Form</see> when
    /// <see cref="Ext.form.Basic.submit">submit</see>ting, when the form's <see cref="Ext.form.BasicConfig.standardSubmit">Ext.form.Basic.standardSubmit</see> config option is true.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class StandardSubmit : Submit
    {
        /// <summary>
        /// Optional target attribute to be used for the form when submitting.
        /// Defaults to the current window/frame.
        /// </summary>
        public JsString target;
        public StandardSubmit(StandardSubmitConfig config){}
        public StandardSubmit(){}
        public StandardSubmit(params object[] args){}
    }
    #endregion
    #region StandardSubmitConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class StandardSubmitConfig : SubmitConfig
    {
        /// <summary>
        /// Optional target attribute to be used for the form when submitting.
        /// Defaults to the current window/frame.
        /// </summary>
        public JsString target;
        public StandardSubmitConfig(params object[] args){}
    }
    #endregion
    #region StandardSubmitEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class StandardSubmitEvents : SubmitEvents
    {
        public StandardSubmitEvents(params object[] args){}
    }
    #endregion
}
