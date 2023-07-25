#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureLensBloomPass.h")]
///<summary>Bloom only rules used for configuring how UComposurePostProcessingPassProxy executes</summary>
public partial class UComposureLensBloomPassPolicy : UComposurePostProcessPassPolicy {
// ComposureLensBloomPassPolicy
	public FLensBloomSettings Settings;
	public UMaterialInterface ReplacementMaterial;
	public string BloomIntensityParamName;
	public UMaterialInstanceDynamic TonemapperReplacmentMID;
}
