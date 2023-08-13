namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UReverbVolumeComponent - Audio Gameplay Volume component for reverb settings</summary>
[CppInclude("ReverbVolumeComponent.h")]
public partial class UReverbVolumeComponent : UAudioGameplayVolumeMutator {
	public static UClass StaticClass() {return default;}
	///<summary>SetReverbSettings</summary>
	public void SetReverbSettings(FReverbSettings NewReverbSettings) {}
	///<summary>Reverb settings to use with this component</summary>
	public FReverbSettings ReverbSettings;
}
