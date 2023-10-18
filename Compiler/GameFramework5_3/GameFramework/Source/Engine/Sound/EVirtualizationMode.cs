namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundBase.h")]
///<summary>Method of virtualization when a sound is stopped due to playback constraints</summary>
public enum EVirtualizationMode {
	Disabled=0,
	PlayWhenSilent=1,
	Restart=2,
}
