#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkRemapAsset.h")]
///<summary>Remap asset for data coming from Live Link. Allows simple application of bone transforms into current pose based on name remapping only</summary>
public partial class ULiveLinkRemapAsset : ULiveLinkRetargetAsset {
// LiveLinkRemapAsset
	public  string GetRemappedBoneName(string BoneName) { return default; }
	public  string GetRemappedCurveName(string CurveName) { return default; }
	public  void RemapCurveElements(TMap<string,float> CurveItems) {}
}
