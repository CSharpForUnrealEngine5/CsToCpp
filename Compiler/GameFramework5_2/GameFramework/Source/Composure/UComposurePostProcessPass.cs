#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposurePostProcessPass.h")]
///<summary>In engine post process based pass.</summary>
public partial class UComposurePostProcessPass : USceneComponent {
// ComposurePostProcessPass
	public void SetSetupMaterial(UObject Material) {}
	public UObject GetSetupMaterial() { return default; }
	public UObject GetOutputRenderTarget() { return default; }
	public void SetOutputRenderTarget(UObject RenderTarget) {}
	public USceneCaptureComponent2D SceneCapture;
	public UComposurePostProcessBlendable BlendableInterface;
	public UMaterialInterface SetupMaterial;
	public UMaterialInterface TonemapperReplacement;
}
