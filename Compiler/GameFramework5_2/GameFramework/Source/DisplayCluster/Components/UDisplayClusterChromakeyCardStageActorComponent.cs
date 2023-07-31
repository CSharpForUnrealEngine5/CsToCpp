#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stage Actor Component to be placed in chromakey card actors</summary>
[CppInclude("Components/DisplayClusterChromakeyCardStageActorComponent.h")]
public partial class UDisplayClusterChromakeyCardStageActorComponent : UDisplayClusterStageActorComponent {
	///<summary>Associate this Chromakey Card with the nDisplay configuration actor and ICVFX Camera component(s) specified here.</summary>
	public TArray<FSoftComponentReference> ICVFXCameras;
}
