#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties</summary>
[CppInclude("RemoveOccludedTrianglesTool.h")]
public partial class URemoveOccludedTrianglesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The method for deciding whether a triangle is occluded</summary>
	public EOcclusionCalculationUIMode OcclusionTestMethod;
	///<summary>Where to sample triangles to test occlusion</summary>
	public EOcclusionTriangleSamplingUIMode TriangleSampling;
	///<summary>The winding isovalue for GeneralizedWindingNumber mode</summary>
	public double WindingIsoValue;
	///<summary>For raycast-based occlusion tests, optionally add random ray direction to increase the accuracy of the visibility sampling</summary>
	public int AddRandomRays;
	///<summary>Optionally add random samples to each triangle (in addition to those from TriangleSampling) to increase the accuracy of the visibility sampling</summary>
	public int AddTriangleSamples;
	///<summary>If false, when multiple meshes are selected the meshes can occlude each other.  When true, we process each selected mesh independently and only consider self-occlusions.</summary>
	public bool bOnlySelfOcclude;
	///<summary>Shrink (erode) the boundary of the set of triangles to remove.</summary>
	public int ShrinkRemoval;
	///<summary>MinAreaIsland</summary>
	public double MinAreaIsland;
	///<summary>MinTriCountIsland</summary>
	public int MinTriCountIsland;
	///<summary>What action to perform on occluded triangles</summary>
	public EOccludedAction Action;
}
