#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about net startup actors that need to be rolled back by being destroyed and re-created</summary>
[CppInclude("Engine/DemoNetDriver.h")]
public partial struct FRollbackNetStartupActorInfo {
	public UObject Archetype;
	public TArray<UObject> ObjReferences;
}
