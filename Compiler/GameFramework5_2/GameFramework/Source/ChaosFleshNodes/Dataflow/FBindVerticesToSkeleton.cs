#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
///<summary>Connects vertices to a rig so that the vertices can be animated</summary>
public partial struct FBindVerticesToSkeleton {
// BindVerticesToSkeleton
	public FManagedArrayCollection Collection;
	public TArray<int> VertexIndices;
	public int OriginBoneIndex;
}
