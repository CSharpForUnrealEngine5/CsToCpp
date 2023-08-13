namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshTetrahedralNodes.h")]
public partial struct FGenerateTetrahedralCollectionDataflowNodes {
	public TetMeshingMethod Method;
	public int NumCells;
	public double OffsetPercent;
	public double IdealEdgeLength;
	public int MaxIterations;
	public double StopEnergy;
	public double EpsRel;
	public bool bCoarsen;
	public bool bExtractManifoldBoundarySurface;
	public bool bSkipSimplification;
	public bool bInvertOutputTets;
	public UStaticMesh StaticMesh;
	public USkeletalMesh SkeletalMesh;
	public bool bComputeByComponent;
	public FManagedArrayCollection Collection;
}
