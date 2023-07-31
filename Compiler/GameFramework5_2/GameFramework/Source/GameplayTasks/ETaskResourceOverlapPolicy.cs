#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask.h")]
public enum ETaskResourceOverlapPolicy {
	StartOnTop=0,
	StartAtEnd=1,
	RequestCancelAndStartOnTop=2,
	RequestCancelAndStartAtEnd=3,
}
