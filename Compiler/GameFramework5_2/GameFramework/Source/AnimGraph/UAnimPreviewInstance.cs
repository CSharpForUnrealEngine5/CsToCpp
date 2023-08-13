namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Instance only contains one AnimationAsset, and produce poses</summary>
[CppInclude("AnimPreviewInstance.h")]
public partial class UAnimPreviewInstance : UAnimSingleNodeInstance {
	public static UClass StaticClass() {return default;}
	///<summary>Shared parameters for previewing blendspace or animsequence *</summary>
	public EMontagePreviewType MontagePreviewType;
	///<summary>MontagePreviewStartSectionIdx</summary>
	public int MontagePreviewStartSectionIdx;
}
