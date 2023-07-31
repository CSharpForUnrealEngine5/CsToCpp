#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCue_Types.h")]
///<summary>Describes what type of payload is attached to a cue execution, we only replicate what is needed</summary>
public enum EGameplayCuePayloadType {
	CueParameters=0,
	FromSpec=1,
}
