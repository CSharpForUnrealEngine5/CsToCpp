namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshPositionTargetInitializationNodes.h")]
public partial struct FAddKinematicParticlesDataflowNode {
	public float Radius;
	public FTransform Transform;
	public ESkeletalSeletionMode SkeletalSelectionMode;
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<int> VertexIndicesIn;
	public int BoneIndexIn;
	public TArray<int> TargetIndicesOut;
}
