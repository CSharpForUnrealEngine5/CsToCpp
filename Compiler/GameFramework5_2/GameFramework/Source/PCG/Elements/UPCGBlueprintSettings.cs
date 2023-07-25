#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintSettings : UPCGSettings {
// PCGBlueprintSettings
	public void SetElementType(UClass InElementType,UObject ElementInstance) {}
	public UClass GetElementType() { return default; }
	public UClass BlueprintElement_DEPRECATED;
	public UClass BlueprintElementType;
	public UPCGBlueprintElement BlueprintElementInstance;
	public TArray<string> TrackedActorTags;
	public bool bTrackActorsOnlyWithinBounds;
	public bool bCreatesArtifacts_DEPRECATED;
	public bool bCanBeMultithreaded_DEPRECATED;
}
