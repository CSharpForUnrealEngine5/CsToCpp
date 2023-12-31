namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mesh Vertex Sculpt Tool Class</summary>
[CppInclude("MeshVertexSculptTool.h")]
public partial class UMeshVertexSculptTool : UMeshSculptToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>Properties that control sculpting</summary>
	public UVertexBrushSculptProperties SculptProperties;
	///<summary>AlphaProperties</summary>
	public UVertexBrushAlphaProperties AlphaProperties;
	///<summary>BrushAlpha</summary>
	public UTexture2D BrushAlpha;
	///<summary>SymmetryProperties</summary>
	public UMeshSymmetryProperties SymmetryProperties;
	///<summary>PreviewMeshActor</summary>
	public AInternalToolFrameworkActor PreviewMeshActor;
	///<summary>DynamicMeshComponent</summary>
	public UDynamicMeshComponent DynamicMeshComponent;
}
