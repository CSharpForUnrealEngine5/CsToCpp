#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpRequestProxyObject.h")]
public partial class UHttpRequestProxyObject : UObject {
// HttpRequestProxyObject
	public FOnRequestComplete OnRequestComplete;
	public UObject CreateHttpRequestProxyObject(string InUrl,string InVerb,FHttpHeader InHeader,string InBody) { return default; }
	public FHttpHeader CachedHeader;
}
