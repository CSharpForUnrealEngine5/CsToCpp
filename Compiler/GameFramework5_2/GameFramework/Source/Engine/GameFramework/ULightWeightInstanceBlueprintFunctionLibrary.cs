#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/LightWeightInstanceBlueprintFunctionLibrary.h")]
public partial class ULightWeightInstanceBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a handle to a new light weight instance that represents an object of type ActorClass</summary>
	public static FActorInstanceHandle CreateNewLightWeightInstance(UClass ActorClass,FTransform Transform,UDataLayerInstance Layer,UWorld World) { return default; }
	///<summary>Returns a handle to the light weight representation and destroys Actor if successful; Returns a handle to Actor otherwise</summary>
	public static FActorInstanceHandle ConvertActorToLightWeightInstance(AActor Actor) { return default; }
}
