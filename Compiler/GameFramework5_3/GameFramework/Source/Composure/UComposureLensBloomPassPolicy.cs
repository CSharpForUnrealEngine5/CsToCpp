namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Bloom only rules used for configuring how UComposurePostProcessingPassProxy executes</summary>
[CppInclude("ComposureLensBloomPass.h")]
public partial class UComposureLensBloomPassPolicy : UComposurePostProcessPassPolicy {
	public static UClass StaticClass() {return default;}
	///<summary>Bloom settings.</summary>
	public FLensBloomSettings Settings;
	///<summary>ReplacementMaterial</summary>
	public UMaterialInterface ReplacementMaterial;
	///<summary>BloomIntensityParamName</summary>
	public FName BloomIntensityParamName;
	///<summary>TonemapperReplacmentMID</summary>
	public UMaterialInstanceDynamic TonemapperReplacmentMID;
}
