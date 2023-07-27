#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableTetrahedralComponent.h")]
///<summary>UDeformableTetrahedralComponent</summary>
public partial class UDeformableTetrahedralComponent : UDeformablePhysicsComponent {
// DeformableTetrahedralComponent
	public  TArray<FVector> GetSkeletalMeshBindingPositions(USkeletalMesh InSkeletalMesh) { return default; }
	public  TArray<FVector> GetSkeletalMeshEmbeddedPositions(ChaosDeformableBindingOption Format,FTransform TargetDeformationSkeletonOffset,string TargetBone/*=""*/,float SimulationBlendWeight/*=1.0f*/) { return default; }
	public FFleshSimulationSpaceGroup SimulationSpace;
	public FBodyForcesGroup BodyForces;
	public float MassMultiplier;
	public UProceduralMeshComponent Mesh;
	public UFleshAsset RestCollection;
	public UFleshDynamicAsset DynamicCollection;
	public USimulationAsset SimulationCollection;
	public  TArray<string> GetSimSpaceBoneNameOptions() { return default; }
}
