namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask.h")]
public enum ETaskResourceOverlapPolicy {
	StartOnTop=0,
	StartAtEnd=1,
	RequestCancelAndStartOnTop=2,
	RequestCancelAndStartAtEnd=3,
}
