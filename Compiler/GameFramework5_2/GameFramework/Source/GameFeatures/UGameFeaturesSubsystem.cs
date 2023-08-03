#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The manager subsystem for game features</summary>
[CppInclude("GameFeaturesSubsystem.h")]
public partial class UGameFeaturesSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>The list of all game feature plugin state machine objects</summary>
	public TMap<FGameFeaturePluginIdentifier,UGameFeaturePluginStateMachine> GameFeaturePluginStateMachines;
	///<summary>Game feature plugin state machine objects that are being terminated. Used to prevent GC until termination is complete.</summary>
	public TArray<UGameFeaturePluginStateMachine> TerminalGameFeaturePluginStateMachines;
	///<summary>Observers</summary>
	public TArray<UObject> Observers;
	///<summary>GameSpecificPolicies</summary>
	public UGameFeaturesProjectPolicies GameSpecificPolicies;
}
