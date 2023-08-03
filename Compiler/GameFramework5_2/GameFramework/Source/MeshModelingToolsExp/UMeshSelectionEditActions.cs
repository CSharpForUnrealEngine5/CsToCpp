#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public partial class UMeshSelectionEditActions : UMeshSelectionToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Clear the active triangle selection</summary>
	public  void Clear() {}
	///<summary>Select all triangles in the mesh</summary>
	public  void SelectAll() {}
	///<summary>Invert the active triangle selection</summary>
	public  void Invert() {}
	///<summary>Grow the active triangle selection to include any triangles touching a vertex on the selection boundary</summary>
	public  void Grow() {}
	///<summary>Shrink the active triangle selection by removing any triangles touching a vertex on the selection boundary</summary>
	public  void Shrink() {}
	///<summary>Grow the active selection to include any triangle connected via shared edges (ie flood-fill)</summary>
	public  void FloodFill() {}
	///<summary>Select the largest connected mesh component by triangle count</summary>
	public  void LargestTriCountPart() {}
	///<summary>Select the largest connected mesh component by mesh area</summary>
	public  void LargestAreaPart() {}
	///<summary>Optimize the selection border by removing &quot;fin&quot; triangles and including &quot;ear&quot; triangles</summary>
	public  void OptimizeBorder() {}
	///<summary>Expand the selection to include all triangles with Materials matching the Materials on the currently selected triangles</summary>
	public  void ExpandToMaterials() {}
}
