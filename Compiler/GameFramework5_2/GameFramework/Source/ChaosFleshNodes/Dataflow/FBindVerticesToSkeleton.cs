namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Connects vertices to a rig so that the vertices can be animated</summary>
[CppInclude("Dataflow/ChaosFleshKinematicInitializationNodes.h")]
public partial struct FBindVerticesToSkeleton {
	public FManagedArrayCollection Collection;
	public TArray<int> VertexIndices;
	public int OriginBoneIndex;
}
