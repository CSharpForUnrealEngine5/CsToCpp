namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A template asset to store appearance settings from Light Card actors.</summary>
[CppInclude("LightCardTemplates/DisplayClusterLightCardTemplate.h")]
public partial class UDisplayClusterLightCardTemplate : UDisplayClusterStageActorTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>The instanced template object containing user settings for the light card.</summary>
	public ADisplayClusterLightCardActor LightCardActor;
}
