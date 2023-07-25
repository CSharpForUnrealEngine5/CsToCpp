#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Struct that allows for different ways to reference a component using TSoftObjectPtr.</summary>
public partial struct FSoftComponentReference {
// SoftComponentReference
	public TSoftObjectPtr<AActor> OtherActor;
}
