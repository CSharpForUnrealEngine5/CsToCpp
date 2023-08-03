#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serves as a container for the background texture/material display in the UVEditor. This class is responsible for managing the quad</summary>
[CppInclude("UVEditorBackgroundPreview.h")]
public partial class UUVEditorBackgroundPreview : UPreviewGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>Visualization settings</summary>
	public UUVEditorBackgroundPreviewProperties Settings;
	///<summary>The component containing the quad visualization</summary>
	public UTriangleSetComponent BackgroundComponent;
	///<summary>The active material being displayed for the background</summary>
	public UMaterialInstanceDynamic BackgroundMaterial;
}
