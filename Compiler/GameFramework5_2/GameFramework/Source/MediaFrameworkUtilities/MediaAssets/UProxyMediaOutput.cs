#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A media output that redirect to another media output.</summary>
[CppInclude("MediaAssets/ProxyMediaOutput.h")]
public partial class UProxyMediaOutput : UMediaOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic media output proxy.</summary>
	public UMediaOutput DynamicProxy;
	///<summary>Media output proxy.</summary>
	public UMediaOutput Proxy;
	///<summary>Is the media proxy has a valid proxy.</summary>
	public  bool IsProxyValid() { return default; }
}
