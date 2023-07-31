#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/ChildActorComponent.h")]
public partial struct FChildActorComponentInstanceData {
	public UClass ChildActorClass;
	public string ChildActorName;
	public TArray<FChildActorAttachedActorInfo> AttachedActors;
}
