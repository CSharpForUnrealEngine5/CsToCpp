#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PolyEdit Actions</summary>
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsToolActions : UEditMeshPolygonsToolActionPropertySet {
	///<summary>Extrude the current set of selected faces by moving and stitching them.</summary>
	public  void Extrude() {}
	///<summary>Like Extrude/Offset, but performed in a boolean way, meaning that the faces can cut away the mesh or bridge mesh parts.</summary>
	public  void PushPull() {}
	///<summary>Like Extrude, but defaults to moving verts along vertex normals instead of a single direction.</summary>
	public  void Offset() {}
	///<summary>Inset the current set of selected faces. Click in viewport to confirm inset distance.</summary>
	public  void Inset() {}
	///<summary>Outset the current set of selected faces. Click in viewport to confirm outset distance.</summary>
	public  void Outset() {}
	///<summary>Bevel the edge loops around the selected faces, inserting edge-aligned faces that interpolate the normals of the selected faces</summary>
	public  void Bevel() {}
	///<summary>Merge the current set of selected faces into a single face</summary>
	public  void Merge() {}
	///<summary>Delete the current set of selected faces</summary>
	public  void Delete() {}
	///<summary>Cut the current set of selected faces. Click twice in viewport to set cut line.</summary>
	public  void CutFaces() {}
	///<summary>Recalculate normals for the current set of selected faces</summary>
	public  void RecalcNormals() {}
	///<summary>Flip normalsand face orientation for the current set of selected faces</summary>
	public  void Flip() {}
	///<summary>Retriangulate each of the selected faces</summary>
	public  void Retriangulate() {}
	///<summary>Split each of the selected faces into a separate polygon for each triangle</summary>
	public  void Decompose() {}
	///<summary>Separate the selected faces at their borders</summary>
	public  void Disconnect() {}
	///<summary>Duplicate the selected faces at their borders</summary>
	public  void Duplicate() {}
	///<summary>Insert a chain of edges across quads (faces with four edges) in the mesh. Due to ambiguity, edges will not be inserted on non-quad faces.</summary>
	public  void InsertEdgeLoop() {}
	///<summary>Insert a new edge connecting existing edges or vertices on a single face</summary>
	public  void InsertEdge() {}
	///<summary>Simplify every polygon group by removing vertices on shared straight edges and retriangulating</summary>
	public  void SimplifyByGroups() {}
}
