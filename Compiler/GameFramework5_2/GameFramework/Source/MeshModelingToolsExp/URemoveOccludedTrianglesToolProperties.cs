#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoveOccludedTrianglesTool.h")]
///<summary>Standard properties</summary>
public partial class URemoveOccludedTrianglesToolProperties : UInteractiveToolPropertySet {
// RemoveOccludedTrianglesToolProperties
	public EOcclusionCalculationUIMode OcclusionTestMethod;
	public EOcclusionTriangleSamplingUIMode TriangleSampling;
	public double WindingIsoValue;
	public int AddRandomRays;
	public int AddTriangleSamples;
	public bool bOnlySelfOcclude;
	public int ShrinkRemoval;
	public double MinAreaIsland;
	public int MinTriCountIsland;
	public EOccludedAction Action;
}
