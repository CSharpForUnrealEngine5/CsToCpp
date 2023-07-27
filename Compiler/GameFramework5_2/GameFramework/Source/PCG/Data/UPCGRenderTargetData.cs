#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGRenderTargetData.h")]
///<summary>TODO: It's possible that caching the result in this class is not as efficient as it could be</summary>
public partial class UPCGRenderTargetData : UPCGBaseTextureData {
// PCGRenderTargetData
	public  void Initialize(UTextureRenderTarget2D InRenderTarget,FTransform InTransform) {}
	public UTextureRenderTarget2D RenderTarget;
}
