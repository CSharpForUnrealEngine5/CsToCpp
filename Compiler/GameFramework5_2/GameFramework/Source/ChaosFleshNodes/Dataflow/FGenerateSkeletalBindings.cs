#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generate barycentric bindings (used by the FleshDeformer deformer graph) of a render surface to a tetrahedral mesh.</summary>
[CppInclude("Dataflow/ChaosFleshSkeletalBindingsNode.h")]
public partial struct FGenerateSkeletalBindings {
	public FManagedArrayCollection Collection;
	public int BoneIndexIn;
	public USkeletalMesh SkeletalMeshIn;
}
