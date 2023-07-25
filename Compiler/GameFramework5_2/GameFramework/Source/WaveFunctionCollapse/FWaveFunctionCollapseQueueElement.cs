#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseModel.h")]
///<summary>A helper struct used for queuing during Observation and Propagation phases</summary>
public partial struct FWaveFunctionCollapseQueueElement {
// WaveFunctionCollapseQueueElement
	public int CenterObjectIndex;
	public EWaveFunctionCollapseAdjacency Adjacency;
}
