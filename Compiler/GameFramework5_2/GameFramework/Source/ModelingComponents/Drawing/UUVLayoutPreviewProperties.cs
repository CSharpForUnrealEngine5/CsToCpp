#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/UVLayoutPreview.h")]
///<summary>Visualization settings for UV layout preview</summary>
public partial class UUVLayoutPreviewProperties : UInteractiveToolPropertySet {
// UVLayoutPreviewProperties
	public bool bEnabled;
	public EUVLayoutPreviewSide Side;
	public float Scale;
	public FVector2D Offset;
	public bool bShowWireframe;
}
