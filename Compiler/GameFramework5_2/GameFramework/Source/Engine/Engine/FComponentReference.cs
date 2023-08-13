namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that allows for different ways to reference a component using TObjectPtr.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FComponentReference {
	public TWeakObjectPtr<AActor> OtherActor;
}
