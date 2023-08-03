#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpRequestProxyObject.h")]
public partial class UHttpRequestProxyObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OnRequestComplete</summary>
	public FOnRequestComplete OnRequestComplete;
	///<summary>CreateHttpRequestProxyObject</summary>
	public static UHttpRequestProxyObject CreateHttpRequestProxyObject(string InUrl,string InVerb,FHttpHeader InHeader,string InBody) { return default; }
	///<summary>CachedHeader</summary>
	public FHttpHeader CachedHeader;
}
