#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPUtilitiesEditorBlueprintLibrary.h")]
public partial class UVPUtilitiesEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Spawn an editor-only virtual production tickable actor</summary>
	public static AVPEditorTickableActorBase SpawnVPEditorTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation) { return default; }
	///<summary>Spawn an editor-only transient virtual production tickable actor</summary>
	public static AVPTransientEditorTickableActorBase SpawnVPTransientEditorTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation) { return default; }
	///<summary>Imports Image file into VirtualProduction/Snapshots/ folder</summary>
	public static UTexture ImportSnapshotTexture(string FileName,string SubFolderName,string AbsolutePathPackage) { return default; }
	///<summary>Get the default OSC server.</summary>
	public static UOSCServer GetDefaultOSCServer() { return default; }
}
