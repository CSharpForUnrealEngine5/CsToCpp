namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakingAnimationKeySettings.h")]
public partial struct FBakingAnimationKeySettings {
	public FFrameNumber StartFrame;
	public FFrameNumber EndFrame;
	public EBakingKeySettings BakingKeySettings;
	public int FrameIncrement;
	public bool bReduceKeys;
	public float Tolerance;
}
