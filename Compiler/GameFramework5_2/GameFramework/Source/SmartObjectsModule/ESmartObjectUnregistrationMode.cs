#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Mode that indicates how the unregistration of the SmartObjectComponent affects its runtime instance.</summary>
public enum ESmartObjectUnregistrationMode {
	KeepRuntimeInstanceActiveIfPartOfCollection=0,
	DestroyRuntimeInstance=1,
}
