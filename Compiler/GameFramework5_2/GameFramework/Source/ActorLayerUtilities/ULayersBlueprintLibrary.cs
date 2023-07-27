#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorLayerUtilities.h")]
///<summary>Function library containing methods for interacting with editor layers</summary>
public partial class ULayersBlueprintLibrary : UBlueprintFunctionLibrary {
// LayersBlueprintLibrary
	public static TArray<AActor> GetActors(UObject WorldContextObject,FActorLayer ActorLayer) { return default; }
	public static void AddActorToLayer(AActor InActor,FActorLayer Layer) {}
	public static void RemoveActorFromLayer(AActor InActor,FActorLayer Layer) {}
}
