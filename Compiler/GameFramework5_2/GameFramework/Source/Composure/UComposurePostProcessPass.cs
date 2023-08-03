#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>In engine post process based pass.</summary>
[CppInclude("ComposurePostProcessPass.h")]
public partial class UComposurePostProcessPass : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sets a custom setup post process material. The material location must be set at BeforeTranslucency.</summary>
	public  void SetSetupMaterial(UMaterialInterface Material) {}
	///<summary>Gets current setup material.</summary>
	public  UMaterialInterface GetSetupMaterial() { return default; }
	///<summary>Gets current output render target.</summary>
	public  UTextureRenderTarget2D GetOutputRenderTarget() { return default; }
	///<summary>Sets current output render target.</summary>
	public  void SetOutputRenderTarget(UTextureRenderTarget2D RenderTarget) {}
	///<summary>Underlying scene capture.</summary>
	public USceneCaptureComponent2D SceneCapture;
	///<summary>Blendable interface to intercept the OverrideBlendableSettings.</summary>
	public UComposurePostProcessBlendable BlendableInterface;
	///<summary>Setup post process material.</summary>
	public UMaterialInterface SetupMaterial;
	///<summary>Internal material that replace the tonemapper to output linear color space.</summary>
	public UMaterialInterface TonemapperReplacement;
}
