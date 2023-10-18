namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SingleAnimationPlayData.h")]
public partial struct FSingleAnimationPlayData {
	public UAnimationAsset AnimToPlay;
	public bool bSavedLooping;
	public bool bSavedPlaying;
	public float SavedPosition;
	public float SavedPlayRate;
}
