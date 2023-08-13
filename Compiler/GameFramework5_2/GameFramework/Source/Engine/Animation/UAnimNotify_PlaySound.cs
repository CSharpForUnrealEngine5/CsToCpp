namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify_PlaySound.h")]
public partial class UAnimNotify_PlaySound : UAnimNotify {
	public static UClass StaticClass() {return default;}
	///<summary>Sound to Play</summary>
	public USoundBase Sound;
	///<summary>Volume Multiplier</summary>
	public float VolumeMultiplier;
	///<summary>Pitch Multiplier</summary>
	public float PitchMultiplier;
	///<summary>If this sound should follow its owner</summary>
	public bool bFollow;
	///<summary>bPreviewIgnoreAttenuation</summary>
	public bool bPreviewIgnoreAttenuation;
	///<summary>Socket or bone name to attach sound to</summary>
	public string AttachName;
}
