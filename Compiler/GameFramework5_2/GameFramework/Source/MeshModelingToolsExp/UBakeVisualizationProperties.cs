#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeVisualizationProperties : UInteractiveToolPropertySet {
	///<summary>Preview the texture as an input to the respective material parameter (ex. Normal, Ambient Occlusion)</summary>
	public bool bPreviewAsMaterial;
	///<summary>Adjust the brightness of the preview material; does not affect results stored in textures</summary>
	public float Brightness;
	///<summary>Ambient Occlusion multiplier in the viewport; does not affect results stored in textures</summary>
	public float AOMultiplier;
}
