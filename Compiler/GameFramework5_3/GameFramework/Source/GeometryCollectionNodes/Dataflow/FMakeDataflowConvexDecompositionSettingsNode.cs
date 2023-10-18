namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provide settings for running convex decomposition of geometry</summary>
[CppInclude("Dataflow/GeometryCollectionUtilityNodes.h")]
public partial struct FMakeDataflowConvexDecompositionSettingsNode {
	public float MinSizeToDecompose;
	public float MaxGeoToHullVolumeRatioToDecompose;
	public float ErrorTolerance;
	public int MaxHullsPerGeometry;
	public float MinThicknessTolerance;
	public int NumAdditionalSplits;
	public FDataflowConvexDecompositionSettings DecompositionSettings;
}
