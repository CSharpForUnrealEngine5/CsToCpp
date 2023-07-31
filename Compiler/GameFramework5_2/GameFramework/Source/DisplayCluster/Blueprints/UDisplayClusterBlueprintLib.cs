#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API function library</summary>
[CppInclude("Blueprints/DisplayClusterBlueprintLib.h")]
public partial class UDisplayClusterBlueprintLib : UBlueprintFunctionLibrary {
	///<summary>Return Display Cluster API interface.</summary>
	public static void GetAPI(object /*OutAPI*/ OutAPI) {}
	///<summary>Create a new light card parented to the given nDisplay root actor.</summary>
	public static ADisplayClusterLightCardActor CreateLightCard(ADisplayClusterRootActor RootActor) { return default; }
	///<summary>Create duplicates of a list of existing light cards.</summary>
	public static void DuplicateLightCards(TArray<ADisplayClusterLightCardActor> OriginalLightcards,TArray<ADisplayClusterLightCardActor> OutNewLightCards) {}
	///<summary>Gets a list of all light card actors on the level linked to the specified root actor.</summary>
	public static void FindLightCardsForRootActor(ADisplayClusterRootActor RootActor,TSet<ADisplayClusterLightCardActor> OutLightCards) {}
	///<summary>Gets a list of all chromakey card actors on the level linked to the specified root actor.</summary>
	public static void FindChromakeyCardsForRootActor(ADisplayClusterRootActor RootActor,TSet<ADisplayClusterChromakeyCardActor> OutChromakeyCards) {}
}
