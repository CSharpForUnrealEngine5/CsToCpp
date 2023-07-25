#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureModeSettings.h")]
///<summary>Settings for the Fracture Editor Mode.</summary>
public partial class UFractureModeSettings : UDeveloperSettings {
// FractureModeSettings
	public float ConvexCanExceedFraction;
	public float ConvexSimplificationDistanceThreshold;
	public EConvexOverlapRemoval ConvexRemoveOverlaps;
	public float ConvexOverlapRemovalShrinkPercent;
	public double ConvexFractionAllowRemove;
	public EProximityMethod ProximityMethod;
	public float ProximityDistanceThreshold;
	public bool bProximityUseAsConnectionGraph;
	public EProximityContactMethod ProximityContactMethod;
	public float ProximityContactThreshold;
}
