#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionSettings.h")]
public partial struct FNetworkPredictionDevHUD {
	public string HUDName;
	public TArray<FNetworkPredictionDevHUDItem> Items;
	public bool bRequirePIE;
	public bool bRequireNotPIE;
}
