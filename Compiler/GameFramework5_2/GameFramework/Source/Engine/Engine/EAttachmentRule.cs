#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Rules for attaching components - needs to be kept synced to EDetachmentRule</summary>
public enum EAttachmentRule {
	KeepRelative=0,
	KeepWorld=1,
	SnapToTarget=2,
}
