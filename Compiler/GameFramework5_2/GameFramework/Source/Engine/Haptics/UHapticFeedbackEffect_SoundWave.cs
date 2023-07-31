#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Haptics/HapticFeedbackEffect_SoundWave.h")]
public partial class UHapticFeedbackEffect_SoundWave : UHapticFeedbackEffect_Base {
	///<summary>SoundWave</summary>
	public USoundWave SoundWave;
	///<summary>If true on a vr controller the left and right stereo channels would be applied to the left and right controller, respectively.</summary>
	public bool bUseStereo;
}
