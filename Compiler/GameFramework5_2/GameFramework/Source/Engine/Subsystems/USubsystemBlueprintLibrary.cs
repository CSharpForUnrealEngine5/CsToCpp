#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/SubsystemBlueprintLibrary.h")]
public partial class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary {
// SubsystemBlueprintLibrary
	public static UEngineSubsystem GetEngineSubsystem(UClass Class) { return default; }
	public static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject,UClass Class) { return default; }
	public static ULocalPlayerSubsystem GetLocalPlayerSubsystem(UObject ContextObject,UClass Class) { return default; }
	public static UWorldSubsystem GetWorldSubsystem(UObject ContextObject,UClass Class) { return default; }
	public static UAudioEngineSubsystem GetAudioEngineSubsystem(UObject ContextObject,UClass Class) { return default; }
	public static ULocalPlayerSubsystem GetLocalPlayerSubSystemFromPlayerController(APlayerController PlayerController,UClass Class) { return default; }
}
