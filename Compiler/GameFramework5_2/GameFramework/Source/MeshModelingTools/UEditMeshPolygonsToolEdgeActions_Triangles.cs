#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsToolEdgeActions_Triangles : UEditMeshPolygonsToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Merge selected edges, moving the first edge to the second</summary>
	public  void Weld() {}
	///<summary>Fill the adjacent hole for any selected boundary edges</summary>
	public  void FillHole() {}
	///<summary>Collapse the selected edges, deleting the attached triangles and merging its two vertices into one</summary>
	public  void Collapse() {}
	///<summary>Flip the selected (non-border, non-seam) edges, replacing them with new edges in the crossing direction</summary>
	public  void Flip() {}
	///<summary>Split the selected edges, inserting a new vertex at each edge midpoint</summary>
	public  void Split() {}
}
