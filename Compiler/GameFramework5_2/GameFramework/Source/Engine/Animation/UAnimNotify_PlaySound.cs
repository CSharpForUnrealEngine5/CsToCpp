#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotify_PlaySound.h")]
public partial class UAnimNotify_PlaySound : UAnimNotify {
// AnimNotify_PlaySound
	public USoundBase Sound;
	public float VolumeMultiplier;
	public float PitchMultiplier;
	public bool bFollow;
	public bool bPreviewIgnoreAttenuation;
	public string AttachName;
}
