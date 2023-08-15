namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorComponentInstanceData {
	public UClass ChildActorClass;
	public FName ChildActorName;
	public TArray<FChildActorAttachedActorInfo> AttachedActors;
}
