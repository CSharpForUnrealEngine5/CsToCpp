#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Rules for detaching components - needs to be kept synced to EAttachmentRule</summary>
public enum EDetachmentRule {
	KeepRelative=0,
	KeepWorld=1,
}
