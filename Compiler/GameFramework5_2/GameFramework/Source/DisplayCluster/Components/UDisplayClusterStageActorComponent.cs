#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage Actor Component used to determine root actor ownership</summary>
[CppInclude("Components/DisplayClusterStageActorComponent.h")]
public partial class UDisplayClusterStageActorComponent : UActorComponent {
	///<summary>Associate this content with the nDisplay configuration actor specified here.</summary>
	public TSoftObjectPtr<ADisplayClusterRootActor> RootActor;
}
