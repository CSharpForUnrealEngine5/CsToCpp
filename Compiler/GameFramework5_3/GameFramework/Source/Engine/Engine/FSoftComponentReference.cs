namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that allows for different ways to reference a component using TSoftObjectPtr.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FSoftComponentReference {
	public TSoftObjectPtr<AActor> OtherActor;
}
