#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionSettings.h")]
public partial struct FNetworkPredictionDevHUD {
// NetworkPredictionDevHUD
	public string HUDName;
	public TArray<FNetworkPredictionDevHUDItem> Items;
	public bool bRequirePIE;
	public bool bRequireNotPIE;
}
