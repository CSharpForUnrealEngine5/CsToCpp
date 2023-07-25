#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/UVLayoutPreview.h")]
///<summary>UUVLayoutPreview is a utility object that creates and manages a 3D plane on which a UV layout</summary>
public partial class UUVLayoutPreview : UObject {
// UVLayoutPreview
	public UUVLayoutPreviewProperties Settings;
	public UPreviewMesh PreviewMesh;
	public UTriangleSetComponent TriangleComponent;
	public bool bShowBackingRectangle;
	public UMaterialInterface BackingRectangleMaterial;
}
