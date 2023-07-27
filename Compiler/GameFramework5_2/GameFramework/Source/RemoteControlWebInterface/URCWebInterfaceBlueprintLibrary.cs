#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCWebInterfaceLibrary.h")]
public partial class URCWebInterfaceBlueprintLibrary : UBlueprintFunctionLibrary {
// RCWebInterfaceBlueprintLibrary
	public static TMap<string,AActor> FindMatchingActorsToRebind(string PresetId,TArray<string> PropertyIds) { return default; }
	public static string GetOwnerActorLabel(string PresetId,TArray<string> PropertyIds) { return default; }
	public static void RebindProperties(string PresetId,TArray<string> PropertyIds,AActor NewOwner) {}
	public static TMap<AActor,string> FindAllActorsOfClass(UClass Class) { return default; }
	public static AActor SpawnActor(UClass Class) { return default; }
	public static TMap<AActor,string> GetValuesOfActorsByClass(UClass Class) { return default; }
}
