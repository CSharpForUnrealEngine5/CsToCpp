namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionSettings.h")]
public partial class UNetworkPredictionSettingsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FNetworkPredictionSettings Settings;
	///<summary>DevHUDs</summary>
	public TArray<FNetworkPredictionDevHUD> DevHUDs;
}
