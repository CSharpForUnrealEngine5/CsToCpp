#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/SubsystemBlueprintLibrary.h")]
public partial class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary {
// SubsystemBlueprintLibrary
	public UObject GetEngineSubsystem(UClass Class) { return default; }
	public UObject GetGameInstanceSubsystem(UObject ContextObject,UClass Class) { return default; }
	public UObject GetLocalPlayerSubsystem(UObject ContextObject,UClass Class) { return default; }
	public UObject GetWorldSubsystem(UObject ContextObject,UClass Class) { return default; }
	public UObject GetAudioEngineSubsystem(UObject ContextObject,UClass Class) { return default; }
	public UObject GetLocalPlayerSubSystemFromPlayerController(UObject PlayerController,UClass Class) { return default; }
}
