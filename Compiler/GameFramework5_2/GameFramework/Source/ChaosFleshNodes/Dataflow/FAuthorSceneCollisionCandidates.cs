#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
///<summary>Marks mesh vertices as candidates for scene collision raycasts.  Each vertex has an associated</summary>
public partial struct FAuthorSceneCollisionCandidates {
// AuthorSceneCollisionCandidates
	public FManagedArrayCollection Collection;
	public bool bSurfaceVerticesOnly;
	public TArray<int> VertexIndices;
	public int OriginBoneIndex;
}
