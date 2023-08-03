#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: It&#39;s possible that caching the result in this class is not as efficient as it could be</summary>
[CppInclude("Data/PCGRenderTargetData.h")]
public partial class UPCGRenderTargetData : UPCGBaseTextureData {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize</summary>
	public  void Initialize(UTextureRenderTarget2D InRenderTarget,FTransform InTransform) {}
	///<summary>RenderTarget</summary>
	public UTextureRenderTarget2D RenderTarget;
}
