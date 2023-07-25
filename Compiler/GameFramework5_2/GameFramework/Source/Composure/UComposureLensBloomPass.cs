#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureLensBloomPass.h")]
///<summary>Bloom only pass implemented on top of the in-engine bloom.</summary>
public partial class UComposureLensBloomPass : UComposurePostProcessPass {
// ComposureLensBloomPass
	public FLensBloomSettings Settings;
	public void SetTonemapperReplacingMaterial(UObject Material) {}
	public void BloomToRenderTarget() {}
	public UMaterialInstanceDynamic TonemapperReplacingMID;
}
