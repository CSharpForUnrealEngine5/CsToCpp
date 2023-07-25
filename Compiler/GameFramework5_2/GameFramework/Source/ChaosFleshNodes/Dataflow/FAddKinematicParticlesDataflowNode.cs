#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshPositionTargetInitializationNodes.h")]
public partial struct FAddKinematicParticlesDataflowNode {
// AddKinematicParticlesDataflowNode
	public float Radius;
	public FTransform Transform;
	public ESkeletalSeletionMode SkeletalSelectionMode;
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<int> VertexIndicesIn;
	public int BoneIndexIn;
	public TArray<int> TargetIndicesOut;
}
