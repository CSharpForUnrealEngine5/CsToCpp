#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OpenXRHandTrackingLiveLinkRemapAsset.h")]
///<summary>OpenXR HandTracking LiveLink remapping asset</summary>
public partial class UOpenXRHandTrackingLiveLinkRemapAsset : ULiveLinkRetargetAsset {
// OpenXRHandTrackingLiveLinkRemapAsset
	public bool bHasMetacarpals;
	public bool bRetargetRotationOnly;
	public EQuatSwizzleAxisB SwizzleX;
	public EQuatSwizzleAxisB SwizzleY;
	public EQuatSwizzleAxisB SwizzleZ;
	public EQuatSwizzleAxisB SwizzleW;
	public TMap<string,string> HandTrackingBoneNameMap;
}
