namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformableTetrahedralComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformableTetrahedralComponent.h")]
public partial class UDeformableTetrahedralComponent : UDeformablePhysicsComponent {
	public static UClass StaticClass() {return default;}
	///<summary>@deprecated Use GetSkeletalMeshEmbeddedPositions() instead.</summary>
	public TArray<FVector> GetSkeletalMeshBindingPositions(USkeletalMesh InSkeletalMesh) { return default; }
	///<summary>Get the current positions of the transformation hierarchy from \c TargetDeformationSkeleton,</summary>
	public TArray<FVector> GetSkeletalMeshEmbeddedPositions(ChaosDeformableBindingOption Format,FTransform TargetDeformationSkeletonOffset,FName TargetBone/*=""*/,float SimulationBlendWeight/*=1.0f*/) { return default; }
	///<summary>SimulationSpace</summary>
	public FFleshSimulationSpaceGroup SimulationSpace;
	///<summary>BodyForces</summary>
	public FBodyForcesGroup BodyForces;
	///<summary>MassMultiplier</summary>
	public float MassMultiplier;
	///<summary>Mesh</summary>
	public UProceduralMeshComponent Mesh;
	///<summary>HideTetrahedra</summary>
	public TArray<int> HideTetrahedra;
	///<summary>FleshAsset that describes the simulation rest state.</summary>
	public UFleshAsset RestCollection;
	///<summary>Current simulation state.</summary>
	public UFleshDynamicAsset DynamicCollection;
	///<summary>Simulator input</summary>
	public USimulationAsset SimulationCollection;
	///<summary>Returns a list of bone names from the currently selected skeletal mesh.</summary>
	public TArray<string> GetSimSpaceBoneNameOptions() { return default; }
}
