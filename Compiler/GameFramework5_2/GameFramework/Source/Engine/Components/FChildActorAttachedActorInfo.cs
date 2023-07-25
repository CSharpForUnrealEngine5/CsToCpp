#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorAttachedActorInfo {
// ChildActorAttachedActorInfo
	public TWeakObjectPtr<AActor> Actor;
	public string SocketName;
	public FTransform RelativeTransform;
}
