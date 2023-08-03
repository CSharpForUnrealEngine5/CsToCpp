#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureSample.h")]
public partial class UMaterialExpressionTextureSample : UMaterialExpressionTextureBase {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinates;
	///<summary>Defaults to &#39;Texture&#39; if not specified</summary>
	public FExpressionInput TextureObject;
	///<summary>Defaults to &#39;AutomaticViewMipBias&#39; if not specified</summary>
	public FExpressionInput MipValue;
	///<summary>Coordinates derivative over the X axis</summary>
	public FExpressionInput CoordinatesDX;
	///<summary>Coordinates derivative over the Y axis</summary>
	public FExpressionInput CoordinatesDY;
	///<summary>Ignored if not specified</summary>
	public FExpressionInput AutomaticViewMipBiasValue;
	///<summary>Defines how the MipValue property is applied to the texture lookup</summary>
	public ETextureMipValueMode MipValueMode;
	///<summary>Controls where the sampler for this texture lookup will come from.</summary>
	public ESamplerSourceMode SamplerSource;
	///<summary>Whether the texture should be sampled with per view mip biasing for sharper output with Temporal AA.</summary>
	public bool AutomaticViewMipBias;
	///<summary>only used if Coordinates is not hooked up</summary>
	public byte ConstCoordinate;
	///<summary>only used if MipValue is not hooked up</summary>
	public int ConstMipValue;
}
