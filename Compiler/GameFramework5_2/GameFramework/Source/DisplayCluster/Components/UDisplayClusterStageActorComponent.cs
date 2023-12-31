namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage Actor Component used to determine root actor ownership</summary>
[CppInclude("Components/DisplayClusterStageActorComponent.h")]
public partial class UDisplayClusterStageActorComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Associate this content with the nDisplay configuration actor specified here.</summary>
	public TSoftObjectPtr<ADisplayClusterRootActor> RootActor;
}
