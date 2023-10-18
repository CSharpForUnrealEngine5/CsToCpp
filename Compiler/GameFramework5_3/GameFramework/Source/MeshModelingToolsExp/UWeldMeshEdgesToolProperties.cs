namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WeldMeshEdgesTool.h")]
public partial class UWeldMeshEdgesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
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
	///<summary>Controls split-attribute welding performed after the Mesh weld.  Applies to normals, tangents, UVs and colors.</summary>
	public EWeldMeshEdgesAttributeUIMode AttrWeldingMode;
	///<summary>Threshold on the angle between normals used to determine if split normals should be merged</summary>
	public float SplitNormalThreshold;
	///<summary>Threshold on the angle between tangent used to determine if split tangents should be merged</summary>
	public float SplitTangentsThreshold;
	///<summary>Threshold uv-distance used to determine if split UVs should be merged</summary>
	public float SplitUVThreshold;
	///<summary>Threshold color-distance used to determine if split colors should be merged</summary>
	public float SplitColorThreshold;
}
