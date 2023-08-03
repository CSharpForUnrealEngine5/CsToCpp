#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Game Features framework</summary>
[CppInclude("GameFeaturesSubsystemSettings.h")]
public partial class UGameFeaturesSubsystemSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Name of a singleton class to spawn as the game feature project policy. If empty, it will spawn the default one (UDefaultGameFeaturesProjectPolicies)</summary>
	public FSoftClassPath GameFeaturesManagerClassName;
	///<summary>List of plugins that are forcibly disabled (e.g., via a hotfix)</summary>
	public TArray<string> DisabledPlugins;
	///<summary>List of metadata (additional keys) to try parsing from the .uplugin to provide to FGameFeaturePluginDetails</summary>
	public TArray<string> AdditionalPluginMetadataKeys;
}
