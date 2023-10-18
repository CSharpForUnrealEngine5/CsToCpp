namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigSpacePickerBakeSettings.h")]
public partial struct FRigSpacePickerBakeSettings {
	public FRigElementKey TargetSpace;
	public FBakingAnimationKeySettings Settings;
	public FFrameNumber StartFrame_DEPRECATED;
	public FFrameNumber EndFrame_DEPRECATED;
	public bool bReduceKeys_DEPRECATED;
	public float Tolerance_DEPRECATED;
}
