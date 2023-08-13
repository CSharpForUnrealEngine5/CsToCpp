namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithSceneActor.h")]
public partial class ADatasmithSceneActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Scene</summary>
	public UDatasmithScene Scene;
	///<summary>Map of all the actors related to this Datasmith Scene</summary>
	public TMap<string,TSoftObjectPtr<AActor>> RelatedActors;
}
