#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolProximity.h")]
///<summary>Settings controlling how proximity is detected for geometry collections</summary>
public partial class UFractureProximitySettings : UFractureToolSettings {
// FractureProximitySettings
	public EProximityMethod Method;
	public double DistanceThreshold;
	public EProximityContactMethod ContactMethod;
	public double ContactThreshold;
	public bool bUseAsConnectionGraph;
	public bool bShowProximity;
	public bool bOnlyShowForSelected;
}
