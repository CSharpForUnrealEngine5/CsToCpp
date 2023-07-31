#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioEditorSettings.h")]
public partial class UAudioEditorSettings : UDeveloperSettings {
	///<summary>Whether to pin the Sound Cue asset type when creating new assets.</summary>
	public bool bPinSoundCueInAssetMenu;
	///<summary>Whether to pin the Sound Cue Template asset type when creating new assets.</summary>
	public bool bPinSoundCueTemplateInAssetMenu;
	///<summary>Whether to pin the Sound Attenuation asset type when creating new assets.</summary>
	public bool bPinSoundAttenuationInAssetMenu;
	///<summary>Whether to pin the Sound Concurrency asset type when creating new assets.</summary>
	public bool bPinSoundConcurrencyInAssetMenu;
}
