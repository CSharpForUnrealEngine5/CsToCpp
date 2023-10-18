namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorAttachedActorInfo {
	public TWeakObjectPtr<AActor> Actor;
	public FName SocketName;
	public FTransform RelativeTransform;
}
