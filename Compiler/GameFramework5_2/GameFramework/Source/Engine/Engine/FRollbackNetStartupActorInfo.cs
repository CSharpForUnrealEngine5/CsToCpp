#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DemoNetDriver.h")]
///<summary>Information about net startup actors that need to be rolled back by being destroyed and re-created</summary>
public partial struct FRollbackNetStartupActorInfo {
// RollbackNetStartupActorInfo
	public UObject Archetype;
	public TArray<UObject> ObjReferences;
}
