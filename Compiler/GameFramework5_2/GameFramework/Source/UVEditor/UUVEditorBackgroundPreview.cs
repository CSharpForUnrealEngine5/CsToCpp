#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorBackgroundPreview.h")]
///<summary>Serves as a container for the background texture/material display in the UVEditor. This class is responsible for managing the quad</summary>
public partial class UUVEditorBackgroundPreview : UPreviewGeometry {
// UVEditorBackgroundPreview
	public UUVEditorBackgroundPreviewProperties Settings;
	public UTriangleSetComponent BackgroundComponent;
	public UMaterialInstanceDynamic BackgroundMaterial;
}
