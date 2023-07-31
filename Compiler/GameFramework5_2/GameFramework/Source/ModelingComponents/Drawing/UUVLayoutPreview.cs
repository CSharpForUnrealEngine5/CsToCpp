#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUVLayoutPreview is a utility object that creates and manages a 3D plane on which a UV layout</summary>
[CppInclude("Drawing/UVLayoutPreview.h")]
public partial class UUVLayoutPreview : UObject {
	///<summary>Visualization settings</summary>
	public UUVLayoutPreviewProperties Settings;
	///<summary>PreviewMesh is initialized with a copy of an input mesh with UVs mapped to position, ie such that (X,Y,Z) = (U,V,0)</summary>
	public UPreviewMesh PreviewMesh;
	///<summary>Set of additional triangles to draw, eg for backing rectangle, etc</summary>
	public UTriangleSetComponent TriangleComponent;
	///<summary>Configure whether the backing rectangle should be shown</summary>
	public bool bShowBackingRectangle;
	///<summary>Configure the backing rectangle material</summary>
	public UMaterialInterface BackingRectangleMaterial;
}
