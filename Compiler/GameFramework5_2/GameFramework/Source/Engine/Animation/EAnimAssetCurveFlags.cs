namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCurveTypes.h")]
///<summary>This is curve flags that are saved in asset and *</summary>
public enum EAnimAssetCurveFlags {
	AACF_NONE=0,
	AACF_DriveMorphTarget_DEPRECATED=1,
	AACF_DriveAttribute_DEPRECATED=2,
	AACF_Editable=4,
	AACF_DriveMaterial_DEPRECATED=8,
	AACF_Metadata=16,
	AACF_DriveTrack=32,
	AACF_Disabled=64,
}
