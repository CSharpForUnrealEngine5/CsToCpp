#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeRenderCaptureTool.h")]
public partial class UBakeRenderCaptureVisualizationProperties : UInteractiveToolPropertySet {
	///<summary>If true  preview results by connecting them to corresponding material inputs</summary>
	public bool bPreviewAsMaterial;
	///<summary>Adjust the brightness of the Base Color material input; does not affect results stored in textures</summary>
	public float Brightness;
	///<summary>Adjust the brightness of the Subsurface Color material input; does not affect results stored in textures</summary>
	public float SSBrightness;
	///<summary>Adjust the brightness of the Emissive Color material input; does not affect results stored in textures</summary>
	public float EmissiveScale;
}
