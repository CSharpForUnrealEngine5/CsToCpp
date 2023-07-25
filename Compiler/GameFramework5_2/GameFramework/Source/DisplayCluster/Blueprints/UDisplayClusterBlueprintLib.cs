#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprintLib.h")]
///<summary>Blueprint API function library</summary>
public partial class UDisplayClusterBlueprintLib : UBlueprintFunctionLibrary {
// DisplayClusterBlueprintLib
	public void GetAPI(object /*OutAPI*/ OutAPI) {}
	public UObject CreateLightCard(UObject RootActor) { return default; }
	public void DuplicateLightCards(TArray<UObject> OriginalLightcards,TArray<UObject> OutNewLightCards) {}
	public void FindLightCardsForRootActor(UObject RootActor,TSet<UObject> OutLightCards) {}
	public void FindChromakeyCardsForRootActor(UObject RootActor,TSet<UObject> OutChromakeyCards) {}
}
