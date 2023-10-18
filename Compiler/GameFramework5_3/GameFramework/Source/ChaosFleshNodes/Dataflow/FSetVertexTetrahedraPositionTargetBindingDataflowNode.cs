namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USTRUCT(meta = (DataflowFlesh))</summary>
[CppInclude("Dataflow/ChaosFleshPositionTargetInitializationNodes.h")]
public partial struct FSetVertexTetrahedraPositionTargetBindingDataflowNode {
	public FManagedArrayCollection Collection;
	public TArray<int> TargetIndicesIn;
	public TArray<string> GeometryGroupGuidsIn;
	public float PositionTargetStiffness;
}
