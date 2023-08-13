namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeVisualizationProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Preview the texture as an input to the respective material parameter (ex. Normal, Ambient Occlusion)</summary>
	public bool bPreviewAsMaterial;
	///<summary>Adjust the brightness of the preview material; does not affect results stored in textures</summary>
	public float Brightness;
	///<summary>Ambient Occlusion multiplier in the viewport; does not affect results stored in textures</summary>
	public float AOMultiplier;
}
