#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/AudioOutputTarget.h")]
[CppEnumInNamespace]
public enum EAudioOutputTarget {
	Speaker=0,
	Controller=1,
	ControllerFallbackToSpeaker=2,
}
