#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassRepresentationFragments.h")]
public partial struct FMassVisualizationLODParameters {
// MassVisualizationLODParameters
	public float BaseLODDistance;
	public float VisibleLODDistance;
	public float BufferHysteresisOnDistancePercentage;
	public int LODMaxCount;
	public float DistanceToFrustum;
	public float DistanceToFrustumHysteresis;
	public UScriptStruct FilterTag;
}
