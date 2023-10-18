namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Renders the texture that is used to pixel map</summary>
[CppInclude("DMXPixelMappingPreprocessRenderer.h")]
public partial class UDMXPixelMappingPreprocessRenderer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Size of the input texture (Material and User Widget only)</summary>
	public FVector2D InputSize;
	///<summary>Number of times the pixelmapping input is downsampled</summary>
	public int NumDownSamplePasses;
	///<summary>Defines how the texture is resized after filtering</summary>
	public EDMXPixelMappingRenderingPreprocessorSizeMode OutputSizeMode;
	///<summary>Size of the rendered texture</summary>
	public FIntPoint CustomOutputSize;
	///<summary>Filter material applied to the rendered input</summary>
	public UMaterialInterface FilterMaterial;
	///<summary>Actual material instance dynamic applied to the rendered input</summary>
	public UMaterialInstanceDynamic FilterMID;
	///<summary>If true, the filter material is applied each downsample pass, otherwise only once after the last pass</summary>
	public bool bApplyFilterMaterialEachDownsamplePass;
	///<summary>Blur distance applied, only applicable if the filter matierial has a &quot;BlurDistance&quot; parameter</summary>
	public float BlurDistance;
	///<summary>The texture parameter name in the Filter Material</summary>
	public FName TextureParameterName;
	///<summary>The blur distance parameter name in the Filter Material</summary>
	public FName BlurDistanceParamterName;
	///<summary>If true, shows the input size property</summary>
	public bool bShowInputSize;
}
