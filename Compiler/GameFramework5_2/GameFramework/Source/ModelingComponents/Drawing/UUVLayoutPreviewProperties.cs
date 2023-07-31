#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings for UV layout preview</summary>
[CppInclude("Drawing/UVLayoutPreview.h")]
public partial class UUVLayoutPreviewProperties : UInteractiveToolPropertySet {
	///<summary>Enable the preview UV layout</summary>
	public bool bEnabled;
	///<summary>Which side of the selected object the preview UV layout is shown</summary>
	public EUVLayoutPreviewSide Side;
	///<summary>Uniform scaling factor</summary>
	public float Scale;
	///<summary>Offset relative to the center of the selected object</summary>
	public FVector2D Offset;
	///<summary>Show wireframe mesh in the preview UV layout</summary>
	public bool bShowWireframe;
}
