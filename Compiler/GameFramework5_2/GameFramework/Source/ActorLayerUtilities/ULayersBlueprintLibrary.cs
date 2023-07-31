#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods for interacting with editor layers</summary>
[CppInclude("ActorLayerUtilities.h")]
public partial class ULayersBlueprintLibrary : UBlueprintFunctionLibrary {
	///<summary>Get all the actors in this layer</summary>
	public static TArray<AActor> GetActors(UObject WorldContextObject,FActorLayer ActorLayer) { return default; }
	///<summary>Adds the actor to the specified layer</summary>
	public static void AddActorToLayer(AActor InActor,FActorLayer Layer) {}
	///<summary>Removes the actor from the specified layer</summary>
	public static void RemoveActorFromLayer(AActor InActor,FActorLayer Layer) {}
}
