#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseModel.h")]
///<summary>Container struct for AdjacencyToOptionsMap</summary>
public partial struct FWaveFunctionCollapseAdjacencyToOptionsMap {
// WaveFunctionCollapseAdjacencyToOptionsMap
	public int Contribution;
	public float Weight;
	public TMap<EWaveFunctionCollapseAdjacency,FWaveFunctionCollapseOptions> AdjacencyToOptionsMap;
}
