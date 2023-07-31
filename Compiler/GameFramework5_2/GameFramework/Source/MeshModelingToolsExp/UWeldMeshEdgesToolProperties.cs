#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WeldMeshEdgesTool.h")]
public partial class UWeldMeshEdgesToolProperties : UInteractiveToolPropertySet {
	///<summary>Edges are considered matching if both pairs of endpoint vertices are closer than this distance</summary>
	public float Tolerance;
	///<summary>Only merge unambiguous pairs that have unique duplicate-edge matches</summary>
	public bool bOnlyUnique;
	///<summary>If enabled, after an initial attempt at Welding, attempt to resolve remaining open edges in T-junction configurations via edge splits, and then retry Weld</summary>
	public bool bResolveTJunctions;
	///<summary>Initial number of open boundary edges</summary>
	public int InitialEdges;
	///<summary>Number of remaining open boundary edges</summary>
	public int RemainingEdges;
}
