namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorComponentInstanceData {
	public UClass ChildActorClass;
	public string ChildActorName;
	public TArray<FChildActorAttachedActorInfo> AttachedActors;
}
