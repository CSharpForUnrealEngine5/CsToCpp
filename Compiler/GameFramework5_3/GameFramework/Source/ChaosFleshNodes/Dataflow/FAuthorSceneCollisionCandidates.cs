namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Marks mesh vertices as candidates for scene collision raycasts.  Each vertex has an associated</summary>
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
public partial struct FAuthorSceneCollisionCandidates {
	public FManagedArrayCollection Collection;
	public bool bSurfaceVerticesOnly;
	public TArray<int> VertexIndices;
	public int OriginBoneIndex;
}
