#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaAssets/ProxyMediaOutput.h")]
///<summary>A media output that redirect to another media output.</summary>
public partial class UProxyMediaOutput : UMediaOutput {
// ProxyMediaOutput
	public UMediaOutput DynamicProxy;
	public UMediaOutput Proxy;
	public bool IsProxyValid() { return default; }
}
