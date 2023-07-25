#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeaturesSubsystem.h")]
///<summary>The manager subsystem for game features</summary>
public partial class UGameFeaturesSubsystem : UEngineSubsystem {
// GameFeaturesSubsystem
	public TMap<FGameFeaturePluginIdentifier,UGameFeaturePluginStateMachine> GameFeaturePluginStateMachines;
	public TArray<UGameFeaturePluginStateMachine> TerminalGameFeaturePluginStateMachines;
	public TArray<UObject> Observers;
	public UGameFeaturesProjectPolicies GameSpecificPolicies;
}
