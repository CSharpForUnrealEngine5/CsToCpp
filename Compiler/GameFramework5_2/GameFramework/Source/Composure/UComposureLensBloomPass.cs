#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bloom only pass implemented on top of the in-engine bloom.</summary>
[CppInclude("ComposureLensBloomPass.h")]
public partial class UComposureLensBloomPass : UComposurePostProcessPass {
	public static UClass StaticClass() {return default;}
	///<summary>Bloom settings.</summary>
	public FLensBloomSettings Settings;
	///<summary>Sets a custom tonemapper replacing material instance.</summary>
	public  void SetTonemapperReplacingMaterial(UMaterialInstanceDynamic Material) {}
	///<summary>Blurs the input into the output.</summary>
	public  void BloomToRenderTarget() {}
	///<summary>TonemapperReplacingMID</summary>
	public UMaterialInstanceDynamic TonemapperReplacingMID;
}
