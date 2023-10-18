namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintTool.h")]
public partial class UMeshVertexPaintToolQuickActions : UMeshVertexPaintToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Fill all Vertex Colors with the current Paint color. Current Channel Filter still applies.</summary>
	public void PaintAll() {}
	///<summary>Fill all Vertex Colors with the current Erase color. Current Channel Filter still applies.</summary>
	public void EraseAll() {}
	///<summary>Fill all Vertex Colors with the Color (0,0,0,1). Current Channel Filter still applies.</summary>
	public void FillBlack() {}
	///<summary>Fill all Vertex Colors with the Color (1,1,1,1). Current Channel Filter still applies.</summary>
	public void FillWhite() {}
}
