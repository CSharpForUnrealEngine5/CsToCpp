namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UEditMeshPolygonsToolActions_Triangles : UEditMeshPolygonsToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Extrude the current set of selected faces. Click in viewport to confirm extrude height.</summary>
	public void Extrude() {}
	///<summary>Like Extrude/Offset, but performed in a boolean way, meaning that the faces can cut away the mesh or bridge mesh parts.</summary>
	public void PushPull() {}
	///<summary>Like Extrude, but defaults to moving verts along vertex normals instead of a single direction.</summary>
	public void Offset() {}
	///<summary>Inset the current set of selected faces. Click in viewport to confirm inset distance.</summary>
	public void Inset() {}
	///<summary>Outset the current set of selected faces. Click in viewport to confirm outset distance.</summary>
	public void Outset() {}
	///<summary>Delete the current set of selected faces</summary>
	public void Delete() {}
	///<summary>Cut the current set of selected faces. Click twice in viewport to set cut line.</summary>
	public void CutFaces() {}
	///<summary>Recalculate normals for the current set of selected faces</summary>
	public void RecalcNormals() {}
	///<summary>Flip normals and face orientation for the current set of selected faces</summary>
	public void Flip() {}
	///<summary>Separate the selected faces at their borders</summary>
	public void Disconnect() {}
	///<summary>Duplicate the selected faces</summary>
	public void Duplicate() {}
	///<summary>Insert a new vertex at the center of each selected face</summary>
	public void Poke() {}
}
