#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorLayerUtilities.h")]
///<summary>Function library containing methods for interacting with editor layers</summary>
public partial class ULayersBlueprintLibrary : UBlueprintFunctionLibrary {
// LayersBlueprintLibrary
	public TArray<UObject> GetActors(UObject WorldContextObject,FActorLayer ActorLayer) { return default; }
	public void AddActorToLayer(UObject InActor,FActorLayer Layer) {}
	public void RemoveActorFromLayer(UObject InActor,FActorLayer Layer) {}
}
