namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/AudioComponent.h")]
///<summary>Enum describing the audio component play state</summary>
public enum EAudioComponentPlayState {
	Playing=0,
	Stopped=1,
	Paused=2,
	FadingIn=3,
	FadingOut=4,
	Count=5,
}
