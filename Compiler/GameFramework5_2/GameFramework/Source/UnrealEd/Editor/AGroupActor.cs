#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/GroupActor.h")]
public partial class AGroupActor : AActor {
// GroupActor
	public bool bLocked;
	public TArray<AActor> GroupActors;
	public TArray<AGroupActor> SubGroups;
}
