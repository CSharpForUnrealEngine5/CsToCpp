#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container struct for AdjacencyToOptionsMap</summary>
[CppInclude("WaveFunctionCollapseModel.h")]
public partial struct FWaveFunctionCollapseAdjacencyToOptionsMap {
	public int Contribution;
	public float Weight;
	public TMap<EWaveFunctionCollapseAdjacency,FWaveFunctionCollapseOptions> AdjacencyToOptionsMap;
}
