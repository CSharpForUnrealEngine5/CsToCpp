using CSharpToCpp.Utilities;

namespace GameFramework;

[CppInclude("Components/ActorComponent.h")]
public partial class UActorComponent : UObject {
    [CppConst]
    public UWorld GetWorld() {return null; }
    
    [CppConst]
    public AActor GetOwner() { return null; }
}
