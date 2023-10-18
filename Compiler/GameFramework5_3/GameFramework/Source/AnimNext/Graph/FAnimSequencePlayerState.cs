namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TEST - until we can allocate per-node state again</summary>
[CppInclude("Graph/AnimGraph/AnimNode_AnimNextGraph.h")]
public partial struct FAnimSequencePlayerState {
	public float InternalTimeAccumulator;
	public float PrevInternalTimeAccumulator;
}
