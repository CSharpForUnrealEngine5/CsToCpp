namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCWebInterfaceLibrary.h")]
public partial class URCWebInterfaceBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a list of compatible actors to rebind the remote control preset properties</summary>
	public static TMap<string,AActor> FindMatchingActorsToRebind(string PresetId,TArray<string> PropertyIds) { return default; }
	///<summary>Get the label of the owner actor of the remote control preset properties</summary>
	public static string GetOwnerActorLabel(string PresetId,TArray<string> PropertyIds) { return default; }
	///<summary>Rebind the remote control preset properties to a new owner</summary>
	public static void RebindProperties(string PresetId,TArray<string> PropertyIds,AActor NewOwner) {}
	///<summary>Shortcut function to find all actors of a class</summary>
	public static TMap<AActor,string> FindAllActorsOfClass(UClass Class) { return default; }
	///<summary>Shortcut function to spawn an actor of a class</summary>
	public static AActor SpawnActor(UClass Class) { return default; }
	///<summary>Gets all properties values (as a json) of all actors of type Class</summary>
	public static TMap<AActor,string> GetValuesOfActorsByClass(UClass Class) { return default; }
}
