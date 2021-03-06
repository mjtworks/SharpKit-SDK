//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// A singleton class providing:
    /// <ul>
    /// <li>Easy creation of prefixed class names</li>
    /// <li>Caching of previously created class names for improved performance.</li>
    /// </ul>
    /// </summary>
    public partial class ClassNameManager
    {
        /// <summary>
        /// Returns a class name prefixed with the the value of the
        /// <code>Y.config.classNamePrefix</code> attribute + the provided strings.
        /// Uses the <code>Y.config.classNameDelimiter</code> attribute to delimit the
        /// provided strings. E.g. Y.ClassNameManager.getClassName('foo','bar'); // yui-foo-bar
        /// </summary>
        public void getClassName(object _, object skipPrefix){}
    }
}
