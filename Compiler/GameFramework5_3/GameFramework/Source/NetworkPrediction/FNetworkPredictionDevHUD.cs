namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionSettings.h")]
public partial struct FNetworkPredictionDevHUD {
	public string HUDName;
	public TArray<FNetworkPredictionDevHUDItem> Items;
	public bool bRequirePIE;
	public bool bRequireNotPIE;
}
