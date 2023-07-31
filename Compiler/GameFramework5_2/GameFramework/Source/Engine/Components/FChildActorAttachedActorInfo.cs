#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorAttachedActorInfo {
	public TWeakObjectPtr<AActor> Actor;
	public string SocketName;
	public FTransform RelativeTransform;
}
