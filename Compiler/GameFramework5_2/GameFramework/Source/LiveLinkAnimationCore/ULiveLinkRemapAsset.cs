namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remap asset for data coming from Live Link. Allows simple application of bone transforms into current pose based on name remapping only</summary>
[CppInclude("LiveLinkRemapAsset.h")]
public partial class ULiveLinkRemapAsset : ULiveLinkRetargetAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Blueprint Implementable function for getting a remapped bone name from the original</summary>
	public FName GetRemappedBoneName(FName BoneName) { return default; }
	///<summary>Blueprint Implementable function for getting a remapped curve name from the original</summary>
	public FName GetRemappedCurveName(FName CurveName) { return default; }
	///<summary>Blueprint Implementable function for remapping, adding or otherwise modifying the curve element data from Live Link. This is run after GetRemappedCurveName</summary>
	public void RemapCurveElements(TMap<FName,float> CurveItems) {}
}
