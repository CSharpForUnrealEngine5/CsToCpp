namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NDIRenderTargetVolumeSimCacheData.h")]
public partial class UNDIRenderTargetVolumeSimCacheData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>CompressionType</summary>
	public FName CompressionType;
	///<summary>Frames</summary>
	public TArray<FNDIRenderTargetVolumeSimCacheFrame> Frames;
}
