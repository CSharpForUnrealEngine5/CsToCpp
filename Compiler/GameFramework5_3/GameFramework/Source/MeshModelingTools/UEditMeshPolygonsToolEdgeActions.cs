namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsToolEdgeActions : UEditMeshPolygonsToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Merge selected edges, moving the first edge to the second</summary>
	public void Weld() {}
	///<summary>Make each selected polygroup edge follow a straight path between its endpoints</summary>
	public void Straighten() {}
	///<summary>Fill the adjacent hole for any selected boundary edges</summary>
	public void FillHole() {}
	///<summary>Bevel the selected edges, replacing them with angled faces</summary>
	public void Bevel() {}
	///<summary>Create a new face that connects the selected edges</summary>
	public void Bridge() {}
	///<summary>Simplify the underlying triangulation along the selected edges, when doing so won&#39;t change the shape or UVs, or make low-quality triangles</summary>
	public void Simplify() {}
}
