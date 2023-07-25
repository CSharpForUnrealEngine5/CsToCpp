#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
public partial struct FKinematicInitializationDataflowNode {
// KinematicInitializationDataflowNode
	public float Radius;
	public ESkeletalSeletionMode SkeletalSelectionMode;
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<int> VertexIndicesIn;
	public int BoneIndexIn;
}
