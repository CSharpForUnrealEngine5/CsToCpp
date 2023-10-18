namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper struct used for queuing during Observation and Propagation phases</summary>
[CppInclude("WaveFunctionCollapseModel.h")]
public partial struct FWaveFunctionCollapseQueueElement {
	public int CenterObjectIndex;
	public EWaveFunctionCollapseAdjacency Adjacency;
}
