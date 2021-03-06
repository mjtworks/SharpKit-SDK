//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.Plugin_
{
    /// <summary>
    /// Node plugin which can be used to align a node with another node,
    /// region, or the viewport.
    /// </summary>
    public partial class Align
    {
        /// <summary>
        /// Aligns the center of a node to the center of another node or region.
        /// </summary>
        public void center(object region){}
        /// <summary>
        /// Removes the resize handler, if any. This is called automatically
        /// when unplugged from the host node.
        /// </summary>
        public void destroy(){}
        /// <summary>
        /// Aligns node with a point on another node or region.
        /// Possible alignment points are:
        /// <dl>
        /// <dt>tl</dt>
        /// <dd>top left</dd>
        /// <dt>tr</dt>
        /// <dd>top right</dd>
        /// <dt>bl</dt>
        /// <dd>bottom left</dd>
        /// <dt>br</dt>
        /// <dd>bottom right</dd>
        /// <dt>tc</dt>
        /// <dd>top center</dd>
        /// <dt>bc</dt>
        /// <dd>bottom center</dd>
        /// <dt>rc</dt>
        /// <dd>right center</dd>
        /// <dt>lc</dt>
        /// <dd>left center</dd>
        /// <dt>cc</dt>
        /// <dd>center center</dd>
        /// </dl>
        /// </summary>
        public void to(object region, object regionPoint, object point, object resize){}
    }
}
