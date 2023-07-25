#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Struct that allows for different ways to reference a component using TObjectPtr.</summary>
public partial struct FComponentReference {
// ComponentReference
	public TWeakObjectPtr<AActor> OtherActor;
}
