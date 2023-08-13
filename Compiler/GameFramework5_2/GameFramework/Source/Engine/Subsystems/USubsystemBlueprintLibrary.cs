namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/SubsystemBlueprintLibrary.h")]
public partial class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get a Game Instance Subsystem from the Game Instance associated with the provided context</summary>
	public static UEngineSubsystem GetEngineSubsystem(UClass Class) { return default; }
	///<summary>Get a Game Instance Subsystem from the Game Instance associated with the provided context</summary>
	public static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject,UClass Class) { return default; }
	///<summary>Get a Local Player Subsystem from the Local Player associated with the provided context</summary>
	public static ULocalPlayerSubsystem GetLocalPlayerSubsystem(UObject ContextObject,UClass Class) { return default; }
	///<summary>Get a World Subsystem from the World associated with the provided context</summary>
	public static UWorldSubsystem GetWorldSubsystem(UObject ContextObject,UClass Class) { return default; }
	///<summary>Get an AudioEngine Subsystem from the AudioDevice associated with the provided context</summary>
	public static UAudioEngineSubsystem GetAudioEngineSubsystem(UObject ContextObject,UClass Class) { return default; }
	///<summary>Get a Local Player Subsystem from the LocalPlayer associated with the provided context</summary>
	public static ULocalPlayerSubsystem GetLocalPlayerSubSystemFromPlayerController(APlayerController PlayerController,UClass Class) { return default; }
}
