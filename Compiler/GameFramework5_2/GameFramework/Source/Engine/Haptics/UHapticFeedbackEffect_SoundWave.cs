namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Haptics/HapticFeedbackEffect_SoundWave.h")]
public partial class UHapticFeedbackEffect_SoundWave : UHapticFeedbackEffect_Base {
	public static UClass StaticClass() {return default;}
	///<summary>SoundWave</summary>
	public USoundWave SoundWave;
	///<summary>If true on a vr controller the left and right stereo channels would be applied to the left and right controller, respectively.</summary>
	public bool bUseStereo;
}
