namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>SetElementType</summary>
	public void SetElementType(UClass InElementType,UPCGBlueprintElement ElementInstance) {}
	///<summary>GetElementType</summary>
	public UClass GetElementType() { return default; }
	///<summary>BlueprintElement_DEPRECATED</summary>
	public UClass BlueprintElement_DEPRECATED;
	///<summary>BlueprintElementType</summary>
	public UClass BlueprintElementType;
	///<summary>BlueprintElementInstance</summary>
	public UPCGBlueprintElement BlueprintElementInstance;
	///<summary>TrackedActorTags</summary>
	public TArray<FName> TrackedActorTags;
	///<summary>If this is checked, found actors that are outside component bounds will not trigger a refresh. Only works for tags for now in editor.</summary>
	public bool bTrackActorsOnlyWithinBounds;
	///<summary>bCanBeMultithreaded_DEPRECATED</summary>
	public bool bCanBeMultithreaded_DEPRECATED;
}
