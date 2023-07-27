#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaAssets/ProxyMediaSource.h")]
///<summary>A media source that reditect to another media source.</summary>
public partial class UProxyMediaSource : UMediaSource {
// ProxyMediaSource
	public UMediaSource DynamicProxy;
	public UMediaSource Proxy;
	public  bool IsProxyValid() { return default; }
}
