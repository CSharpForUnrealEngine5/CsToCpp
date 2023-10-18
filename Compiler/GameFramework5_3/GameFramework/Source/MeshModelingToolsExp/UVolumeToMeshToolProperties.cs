namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VolumeToMeshTool.h")]
public partial class UVolumeToMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Weld coincident vertices and edges together in the resulting mesh to form a closed mesh surface.</summary>
	public bool bWeldEdges;
	///<summary>If WeldEdges is enabled, attempt to fill any small holes or cracks in the resulting mesh to form a closed surface.</summary>
	public bool bAutoRepair;
	///<summary>If WeldEdges is enabled, and after mesh generation is complete, flip edges in planar regions to improve triangle quality.</summary>
	public bool bOptimizeMesh;
	///<summary>Show the wireframe of the resulting converted mesh geometry.</summary>
	public bool bShowWireframe;
}
