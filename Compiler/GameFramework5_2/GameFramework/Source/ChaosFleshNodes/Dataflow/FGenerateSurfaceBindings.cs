#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generate barycentric bindings (used by the FleshDeformer deformer graph) of a render surface to a tetrahedral mesh.</summary>
[CppInclude("Dataflow/ChaosFleshBindingsNodes.h")]
public partial struct FGenerateSurfaceBindings {
	public FManagedArrayCollection Collection;
	public UStaticMesh StaticMeshIn;
	public USkeletalMesh SkeletalMeshIn;
	public TArray<string> GeometryGroupGuidsIn;
	public bool bDoSurfaceProjection;
	public uint SurfaceProjectionIterations;
	public bool bDoOrphanReparenting;
}
