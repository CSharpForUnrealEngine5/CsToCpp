#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCWebInterfaceLibrary.h")]
public partial class URCWebInterfaceBlueprintLibrary : UBlueprintFunctionLibrary {
// RCWebInterfaceBlueprintLibrary
	public TMap<string,UObject> FindMatchingActorsToRebind(string PresetId,TArray<string> PropertyIds) { return default; }
	public string GetOwnerActorLabel(string PresetId,TArray<string> PropertyIds) { return default; }
	public void RebindProperties(string PresetId,TArray<string> PropertyIds,UObject NewOwner) {}
	public TMap<UObject,string> FindAllActorsOfClass(UClass Class) { return default; }
	public UObject SpawnActor(UClass Class) { return default; }
	public TMap<UObject,string> GetValuesOfActorsByClass(UClass Class) { return default; }
}
