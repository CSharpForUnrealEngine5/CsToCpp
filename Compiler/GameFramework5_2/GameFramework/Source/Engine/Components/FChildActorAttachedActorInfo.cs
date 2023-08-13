namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorAttachedActorInfo {
	public TWeakObjectPtr<AActor> Actor;
	public string SocketName;
	public FTransform RelativeTransform;
}
