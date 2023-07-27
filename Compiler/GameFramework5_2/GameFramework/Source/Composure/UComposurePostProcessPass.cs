#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePostProcessPass.h")]
///<summary>In engine post process based pass.</summary>
public partial class UComposurePostProcessPass : USceneComponent {
// ComposurePostProcessPass
	public  void SetSetupMaterial(UMaterialInterface Material) {}
	public  UMaterialInterface GetSetupMaterial() { return default; }
	public  UTextureRenderTarget2D GetOutputRenderTarget() { return default; }
	public  void SetOutputRenderTarget(UTextureRenderTarget2D RenderTarget) {}
	public USceneCaptureComponent2D SceneCapture;
	public UComposurePostProcessBlendable BlendableInterface;
	public UMaterialInterface SetupMaterial;
	public UMaterialInterface TonemapperReplacement;
}
