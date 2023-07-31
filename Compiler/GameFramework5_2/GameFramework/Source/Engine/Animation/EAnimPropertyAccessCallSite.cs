#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSubsystem_PropertyAccess.h")]
///<summary>The various call sites we can call into the property access library</summary>
public enum EAnimPropertyAccessCallSite {
	WorkerThread_Unbatched=0,
	WorkerThread_Batched_PreEventGraph=1,
	WorkerThread_Batched_PostEventGraph=2,
	GameThread_Batched_PreEventGraph=3,
	GameThread_Batched_PostEventGraph=4,
}
