namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FDataflowConvexDecompositionSettings {
	public float MinSizeToDecompose;
	public float MaxGeoToHullVolumeRatioToDecompose;
	public float ErrorTolerance;
	public int MaxHullsPerGeometry;
	public float MinThicknessTolerance;
	public int NumAdditionalSplits;
}
