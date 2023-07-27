#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/DisplayClusterBlueprintLib.h")]
///<summary>Blueprint API function library</summary>
public partial class UDisplayClusterBlueprintLib : UBlueprintFunctionLibrary {
// DisplayClusterBlueprintLib
	public static void GetAPI(object /*OutAPI*/ OutAPI) {}
	public static ADisplayClusterLightCardActor CreateLightCard(ADisplayClusterRootActor RootActor) { return default; }
	public static void DuplicateLightCards(TArray<ADisplayClusterLightCardActor> OriginalLightcards,TArray<ADisplayClusterLightCardActor> OutNewLightCards) {}
	public static void FindLightCardsForRootActor(ADisplayClusterRootActor RootActor,TSet<ADisplayClusterLightCardActor> OutLightCards) {}
	public static void FindChromakeyCardsForRootActor(ADisplayClusterRootActor RootActor,TSet<ADisplayClusterChromakeyCardActor> OutChromakeyCards) {}
}
