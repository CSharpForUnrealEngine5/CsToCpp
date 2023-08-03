#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Fracture Editor Mode.</summary>
[CppInclude("FractureModeSettings.h")]
public partial class UFractureModeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Default fraction of geometry volume by which a cluster&#39;s convex hull volume can exceed the actual geometry volume before instead using the hulls of the children.  0 means the convex volume cannot exceed the geometry volume; 1 means the convex volume is allowed to be 100% larger (2x) the geometry volume.</summary>
	public float ConvexCanExceedFraction;
	///<summary>Default simplification threshold for convex hulls of new geometry collections</summary>
	public float ConvexSimplificationDistanceThreshold;
	///<summary>Default overlap removal setting for convex hulls of new geometry collections</summary>
	public EConvexOverlapRemoval ConvexRemoveOverlaps;
	///<summary>Default overlap removal shrink percent (in range 0-100) for convex hulls of new geometry collections. Overlap removal will be computed assuming convex shapes will be scaled down by this percentage.</summary>
	public float ConvexOverlapRemovalShrinkPercent;
	///<summary>Default fraction of convex hulls for a transform that we can remove before using the hulls of the children</summary>
	public double ConvexFractionAllowRemove;
	///<summary>Default method used to detect proximity of geometry in a new geometry collection</summary>
	public EProximityMethod ProximityMethod;
	///<summary>When Proximity Detection Method is Convex Hull, how close two hulls need to be to be considered as &#39;in proximity&#39;</summary>
	public float ProximityDistanceThreshold;
	///<summary>Whether to automatically transform the proximity graph into a connection graph to be used for simulation</summary>
	public bool bProximityUseAsConnectionGraph;
	///<summary>Method to use to determine the contact between two pieces, if the Contact Threshold is greater than 0</summary>
	public EProximityContactMethod ProximityContactMethod;
	///<summary>If greater than zero, proximity will be additionally filtered by a &#39;contact&#39; threshold, in cm, to exclude grazing / corner proximity</summary>
	public float ProximityContactThreshold;
}
