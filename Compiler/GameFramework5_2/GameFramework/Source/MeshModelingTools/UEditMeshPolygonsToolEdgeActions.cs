#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsToolEdgeActions : UEditMeshPolygonsToolActionPropertySet {
	///<summary>Merge selected edges, moving the first edge to the second</summary>
	public  void Weld() {}
	///<summary>Make each selected polygroup edge follow a straight path between its endpoints</summary>
	public  void Straighten() {}
	///<summary>Fill the adjacent hole for any selected boundary edges</summary>
	public  void FillHole() {}
	///<summary>Bevel the selected edges, replacing them with angled faces</summary>
	public  void Bevel() {}
	///<summary>Create a new face that connects the selected edges</summary>
	public  void Bridge() {}
}
