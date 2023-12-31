namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A media source that reditect to another media source.</summary>
[CppInclude("MediaAssets/ProxyMediaSource.h")]
public partial class UProxyMediaSource : UMediaSource {
	public static UClass StaticClass() {return default;}
	///<summary>Cached media source proxy.</summary>
	public UMediaSource DynamicProxy;
	///<summary>Media source proxy.</summary>
	public UMediaSource Proxy;
	///<summary>Is the media proxy has a valid proxy.</summary>
	public bool IsProxyValid() { return default; }
}
