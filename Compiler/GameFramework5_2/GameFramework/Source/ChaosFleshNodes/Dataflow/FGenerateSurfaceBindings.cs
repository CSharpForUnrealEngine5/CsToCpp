#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshBindingsNodes.h")]
///<summary>Generate barycentric bindings (used by the FleshDeformer deformer graph) of a render surface to a tetrahedral mesh.</summary>
public partial struct FGenerateSurfaceBindings {
// GenerateSurfaceBindings
	public FManagedArrayCollection Collection;
	public UStaticMesh StaticMeshIn;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<string> GeometryGroupGuidsIn;
	public bool bDoSurfaceProjection;
	public uint SurfaceProjectionIterations;
	public bool bDoOrphanReparenting;
}
