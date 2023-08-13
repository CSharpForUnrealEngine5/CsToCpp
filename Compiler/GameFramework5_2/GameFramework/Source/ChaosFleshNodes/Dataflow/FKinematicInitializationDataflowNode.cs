namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
public partial struct FKinematicInitializationDataflowNode {
	public float Radius;
	public ESkeletalSeletionMode SkeletalSelectionMode;
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<int> VertexIndicesIn;
	public int BoneIndexIn;
}
