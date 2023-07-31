#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithSceneActor.h")]
public partial class ADatasmithSceneActor : AActor {
	///<summary>Scene</summary>
	public UDatasmithScene Scene;
	///<summary>Map of all the actors related to this Datasmith Scene</summary>
	public TMap<string,TSoftObjectPtr<AActor>> RelatedActors;
}
