#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshSkeletalBindingsNode.h")]
///<summary>Generate barycentric bindings (used by the FleshDeformer deformer graph) of a render surface to a tetrahedral mesh.</summary>
public partial struct FGenerateSkeletalBindings {
// GenerateSkeletalBindings
	public FManagedArrayCollection Collection;
	public int BoneIndexIn;
	public USkeletalMesh SkeletalMeshIn;
}
