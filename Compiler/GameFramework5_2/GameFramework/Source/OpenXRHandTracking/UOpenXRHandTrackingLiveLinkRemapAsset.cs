namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>OpenXR HandTracking LiveLink remapping asset</summary>
[CppInclude("OpenXRHandTrackingLiveLinkRemapAsset.h")]
public partial class UOpenXRHandTrackingLiveLinkRemapAsset : ULiveLinkRetargetAsset {
	public static UClass StaticClass() {return default;}
	///<summary>If true, remap the full human hand skeleton including metacarpals</summary>
	public bool bHasMetacarpals;
	///<summary>Only apply the orientation to each bone</summary>
	public bool bRetargetRotationOnly;
	///<summary>Reorient the skeleton (swizzle the quaternion) to adjust for base skeleton and incoming skeleton differences</summary>
	public EQuatSwizzleAxisB SwizzleX;
	///<summary>SwizzleY</summary>
	public EQuatSwizzleAxisB SwizzleY;
	///<summary>SwizzleZ</summary>
	public EQuatSwizzleAxisB SwizzleZ;
	///<summary>SwizzleW</summary>
	public EQuatSwizzleAxisB SwizzleW;
	///<summary>HandTrackingBoneNameMap</summary>
	public TMap<FName,FName> HandTrackingBoneNameMap;
}
