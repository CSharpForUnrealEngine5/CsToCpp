#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolProperties.h")]
public partial class UFractureRemoveOnBreakSettings : UFractureToolSettings {
// FractureRemoveOnBreakSettings
	public bool Enabled;
	public FVector2f PostBreakTimer;
	public bool ClusterCrumbling;
	public FVector2f RemovalTimer;
	public void DeleteRemoveOnBreakData() {}
}
