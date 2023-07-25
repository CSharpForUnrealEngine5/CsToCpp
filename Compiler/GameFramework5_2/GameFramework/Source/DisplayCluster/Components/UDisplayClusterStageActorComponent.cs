#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterStageActorComponent.h")]
///<summary>Stage Actor Component used to determine root actor ownership</summary>
public partial class UDisplayClusterStageActorComponent : UActorComponent {
// DisplayClusterStageActorComponent
	public TSoftObjectPtr<ADisplayClusterRootActor> RootActor;
}
