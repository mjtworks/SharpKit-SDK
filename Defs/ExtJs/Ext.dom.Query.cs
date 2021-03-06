//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.dom
{
    #region Query
    /// <summary>
    /// <p>Provides high performance selector/xpath processing by compiling queries into reusable functions. New pseudo classes
    /// and matchers can be plugged. It works on HTML and XML documents (if a content node is passed in).</p>
    /// <p>DomQuery supports most of the <i>CSS3 selectors spec</i>, along with some custom selectors and basic XPath.</p>
    /// <p>All selectors, attribute filters and pseudos below can be combined infinitely in any order. For example
    /// <c>div.foo:nth-child(odd)[@foo=bar].bar:first</c> would be a perfectly valid selector. Node filters are processed
    /// in the order in which they appear, which allows you to optimize your queries for your document structure.</p>
    /// <h2>Element Selectors:</h2>
    /// <ul>
    /// <li><strong><c>*</c></strong> any element</li>
    /// <li><strong><c>E</c></strong> an element with the tag E</li>
    /// <li><strong><c>E F</c></strong> All descendent elements of E that have the tag F</li>
    /// <li><strong><c>E &gt; F</c></strong> or <strong>E/F</strong> all direct children elements of E that have the tag F</li>
    /// <li><strong><c>E + F</c></strong> all elements with the tag F that are immediately preceded by an element with the tag E</li>
    /// <li><strong><c>E ~ F</c></strong> all elements with the tag F that are preceded by a sibling element with the tag E</li>
    /// </ul>
    /// <h2>Attribute Selectors:</h2>
    /// <p>The use of <c>@</c> and quotes are optional. For example, <c>div[@foo='bar']</c> is also a valid attribute selector.</p>
    /// <ul>
    /// <li><strong><c>E[foo]</c></strong> has an attribute "foo"</li>
    /// <li><strong><c>E[foo=bar]</c></strong> has an attribute "foo" that equals "bar"</li>
    /// <li><strong><c>E[foo^=bar]</c></strong> has an attribute "foo" that starts with "bar"</li>
    /// <li><strong><c>E[foo$=bar]</c></strong> has an attribute "foo" that ends with "bar"</li>
    /// <li><strong><c>E[foo*=bar]</c></strong> has an attribute "foo" that contains the substring "bar"</li>
    /// <li><strong><c>E[foo%=2]</c></strong> has an attribute "foo" that is evenly divisible by 2</li>
    /// <li><strong><c>E[foo!=bar]</c></strong> attribute "foo" does not equal "bar"</li>
    /// </ul>
    /// <h2>Pseudo Classes:</h2>
    /// <ul>
    /// <li><strong><c>E:first-child</c></strong> E is the first child of its parent</li>
    /// <li><strong><c>E:last-child</c></strong> E is the last child of its parent</li>
    /// <li><strong><c>E:nth-child(_n_)</c></strong> E is the _n_th child of its parent (1 based as per the spec)</li>
    /// <li><strong><c>E:nth-child(odd)</c></strong> E is an odd child of its parent</li>
    /// <li><strong><c>E:nth-child(even)</c></strong> E is an even child of its parent</li>
    /// <li><strong><c>E:only-child</c></strong> E is the only child of its parent</li>
    /// <li><strong><c>E:checked</c></strong> E is an element that is has a checked attribute that is true (e.g. a radio or checkbox)</li>
    /// <li><strong><c>E:first</c></strong> the first E in the resultset</li>
    /// <li><strong><c>E:last</c></strong> the last E in the resultset</li>
    /// <li><strong><c>E:nth(_n_)</c></strong> the _n_th E in the resultset (1 based)</li>
    /// <li><strong><c>E:odd</c></strong> shortcut for :nth-child(odd)</li>
    /// <li><strong><c>E:even</c></strong> shortcut for :nth-child(even)</li>
    /// <li><strong><c>E:contains(foo)</c></strong> E's innerHTML contains the substring "foo"</li>
    /// <li><strong><c>E:nodeValue(foo)</c></strong> E contains a textNode with a nodeValue that equals "foo"</li>
    /// <li><strong><c>E:not(S)</c></strong> an E element that does not match simple selector S</li>
    /// <li><strong><c>E:has(S)</c></strong> an E element that has a descendent that matches simple selector S</li>
    /// <li><strong><c>E:next(S)</c></strong> an E element whose next sibling matches simple selector S</li>
    /// <li><strong><c>E:prev(S)</c></strong> an E element whose previous sibling matches simple selector S</li>
    /// <li><strong><c>E:any(S1|S2|S2)</c></strong> an E element which matches any of the simple selectors S1, S2 or S3</li>
    /// </ul>
    /// <h2>CSS Value Selectors:</h2>
    /// <ul>
    /// <li><strong><c>E{display=none}</c></strong> css value "display" that equals "none"</li>
    /// <li><strong><c>E{display^=none}</c></strong> css value "display" that starts with "none"</li>
    /// <li><strong><c>E{display$=none}</c></strong> css value "display" that ends with "none"</li>
    /// <li><strong><c>E{display*=none}</c></strong> css value "display" that contains the substring "none"</li>
    /// <li><strong><c>E{display%=2}</c></strong> css value "display" that is evenly divisible by 2</li>
    /// <li><strong><c>E{display!=none}</c></strong> css value "display" that does not equal "none"</li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Query
    {
        /// <summary>
        /// Collection of matching regular expressions and code snippets.
        /// Each capture group within () will be replace the {} in the select
        /// statement as specified by their index.
        /// Defaults to: <c>[{re: /^\.([\w\-\\]+)/, select: &quot;n = byClassName(n, &quot; {1} &quot;);&quot;}, {re: /^\:([\w\-]+)(?:\(((?:[^\s&gt;\/]*|.*?))\))?/, select: &quot;n = byPseudo(n, &quot;{1}&quot;, &quot;{2}&quot;);&quot;}, {re: /^(?:([\[\{])(?:@)?([\w\-]+)\s?(?:(=|.=)\s?['&quot;]?(.*?)[&quot;']?)?[\]\}])/, select: &quot;n = byAttribute(n, &quot;{2}&quot;, &quot;{4}&quot;, &quot;{3}&quot;, &quot;{1}&quot;);&quot;}, {re: /^#([\w\-\\]+)/, select: &quot;n = byId(n, &quot;{1}&quot;);&quot;}, {re: /^@([\w\-]+)/, select: &quot;return {firstChild:{nodeValue:attrValue(n, &quot;{1}&quot;)}};&quot;}]</c>
        /// </summary>
        public static JsArray matchers{get;set;}
        /// <summary>
        /// Collection of operator comparison functions.
        /// The default operators are =, !=, ^=, $=, *=, %=, |= and ~=.
        /// New operators can be added as long as the match the format c= where c
        /// is any character other than space, &gt;, or &lt;.
        /// </summary>
        public static JsObject operators{get;set;}
        /// <summary>
        /// Object hash of "pseudo class" filter functions which are used when filtering selections.
        /// Each function is passed two parameters:
        /// <li><p><strong>c</strong> : Array
        /// An Array of DOM elements to filter.</p></li>
        /// <li><p><strong>v</strong> : String
        /// The argument (if any) supplied in the selector.</p></li>
        /// A filter function returns an Array of DOM elements which conform to the pseudo class.
        /// In addition to the provided pseudo classes listed above such as <c>first-child</c> and <c>nth-child</c>,
        /// developers may add additional, custom psuedo class filters to select elements according to application-specific requirements.
        /// For example, to filter <c>a</c> elements to only return links to <strong>external</strong> resources:
        /// <code>Ext.DomQuery.pseudos.external = function(c, v){
        /// var r = [], ri = -1;
        /// for(var i = 0, ci; ci = c[i]; i++){
        /// // Include in result set only if it's a link to an external resource
        /// if(ci.hostname != location.hostname){
        /// r[++ri] = ci;
        /// }
        /// }
        /// return r;
        /// };
        /// </code>
        /// Then external links could be gathered with the following statement:
        /// <code>var externalLinks = <see cref="Ext.ExtContext.select">Ext.select</see>("a:external");
        /// </code>
        /// </summary>
        public static JsObject pseudos{get;set;}
        /// <summary>
        /// Compiles a selector/xpath query into a reusable function. The returned function
        /// takes one parameter "root" (optional), which is the context node from where the query should start.
        /// </summary>
        /// <param name="selector"><p>The selector/xpath query</p>
        /// </param>
        /// <param name="type"><p>Either "select" or "simple" for a simple selector match</p>
        /// <p>Defaults to: <c>&quot;select&quot;</c></p></param>
        /// <returns>
        /// <span><see cref="Function">Function</see></span><div>
        /// </div>
        /// </returns>
        public static System.Delegate compile(object selector, object type=null){return null;}
        /// <summary>
        /// Filters an array of elements to only include matches of a simple selector
        /// (e.g. div.some-class or span:first-child)
        /// </summary>
        /// <param name="el"><p>An array of elements to filter</p>
        /// </param>
        /// <param name="selector"><p>The simple selector to test</p>
        /// </param>
        /// <param name="nonMatches"><p>If true, it returns the elements that DON'T match the selector instead of the
        /// ones that match</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement[]</span><div><p>An Array of DOM elements which match the selector. If there are no matches, and empty
        /// Array is returned.</p>
        /// </div>
        /// </returns>
        public static JsObject[] filter(object el, JsString selector, bool nonMatches){return null;}
        /// <summary>
        /// Returns true if the passed element(s) match the passed simple selector
        /// (e.g. div.some-class or span:first-child)
        /// </summary>
        /// <param name="el"><p>An element id, element or array of elements</p>
        /// </param>
        /// <param name="selector"><p>The simple selector to test</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public static bool @is(object el, JsString selector){return false;}
        /// <summary>
        /// Selects an array of DOM nodes using JavaScript-only implementation.
        /// Use <see cref="Ext.dom.Query.select">select</see> to take advantage of browsers built-in support for CSS selectors.
        /// </summary>
        /// <param name="selector"><p>The selector/xpath query (can be a comma separated list of selectors)</p>
        /// </param>
        /// <param name="root"><p>The start of the query.</p>
        /// <p>Defaults to: <c>document</c></p></param>
        /// <returns>
        /// <span>HTMLElement[]</span><div><p>An Array of DOM elements which match the selector. If there are
        /// no matches, and empty Array is returned.</p>
        /// </div>
        /// </returns>
        public static JsObject[] jsSelect(object selector, object root=null){return null;}
        /// <summary>
        /// Selects an array of DOM nodes by CSS/XPath selector.
        /// Uses <i>document.querySelectorAll</i> if browser supports that, otherwise falls back to
        /// <see cref="Ext.dom.Query.jsSelect">jsSelect</see> to do the work.
        /// Aliased as <see cref="Ext.ExtContext.query">Ext.query</see>.
        /// </summary>
        /// <param name="path"><p>The selector/xpath query</p>
        /// </param>
        /// <param name="root"><p>The start of the query.</p>
        /// <p>Defaults to: <c>document</c></p></param>
        /// <param name="type"><p>Either "select" or "simple" for a simple selector match (only valid when
        /// used when the call is deferred to the jsSelect method)</p>
        /// <p>Defaults to: <c>&quot;select&quot;</c></p></param>
        /// <returns>
        /// <span>HTMLElement[]</span><div><p>An array of DOM elements (not a NodeList as returned by <c>querySelectorAll</c>).</p>
        /// </div>
        /// </returns>
        public static JsObject[] select(object path, object root=null, object type=null){return null;}
        /// <summary>
        /// Selects a single element.
        /// </summary>
        /// <param name="selector"><p>The selector/xpath query</p>
        /// </param>
        /// <param name="root"><p>The start of the query.</p>
        /// <p>Defaults to: <c>document</c></p></param>
        /// <returns>
        /// <span>HTMLElement</span><div><p>The DOM element which matched the selector.</p>
        /// </div>
        /// </returns>
        public static JsObject selectNode(object selector, object root=null){return null;}
        /// <summary>
        /// Selects the value of a node, parsing integers and floats.
        /// Returns the defaultValue, or 0 if none is specified.
        /// </summary>
        /// <param name="selector"><p>The selector/xpath query</p>
        /// </param>
        /// <param name="root"><p>The start of the query.</p>
        /// <p>Defaults to: <c>document</c></p></param>
        /// <param name="defaultValue"><p>When specified, this is return as empty value.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div>
        /// </div>
        /// </returns>
        public static JsNumber selectNumber(object selector, object root=null, object defaultValue=null){return null;}
        /// <summary>
        /// Selects the value of a node, optionally replacing null with the defaultValue.
        /// </summary>
        /// <param name="selector"><p>The selector/xpath query</p>
        /// </param>
        /// <param name="root"><p>The start of the query.</p>
        /// <p>Defaults to: <c>document</c></p></param>
        /// <param name="defaultValue"><p>When specified, this is return as empty value.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public static JsString selectValue(object selector, object root=null, object defaultValue=null){return null;}
        public Query(QueryConfig config){}
        public Query(){}
        public Query(params object[] args){}
    }
    #endregion
    #region QueryConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class QueryConfig
    {
        public QueryConfig(params object[] args){}
    }
    #endregion
    #region QueryEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class QueryEvents
    {
        public QueryEvents(params object[] args){}
    }
    #endregion
}
