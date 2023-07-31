#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationFragments.h")]
public partial struct FMassVisualizationLODParameters {
	public float BaseLODDistance;
	public float VisibleLODDistance;
	public float BufferHysteresisOnDistancePercentage;
	public int LODMaxCount;
	public float DistanceToFrustum;
	public float DistanceToFrustumHysteresis;
	public UScriptStruct FilterTag;
}
