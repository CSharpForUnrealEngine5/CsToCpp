#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureSample.h")]
public partial class UMaterialExpressionTextureSample : UMaterialExpressionTextureBase {
// MaterialExpressionTextureSample
	public FExpressionInput Coordinates;
	public FExpressionInput TextureObject;
	public FExpressionInput MipValue;
	public FExpressionInput CoordinatesDX;
	public FExpressionInput CoordinatesDY;
	public FExpressionInput AutomaticViewMipBiasValue;
	public ETextureMipValueMode MipValueMode;
	public ESamplerSourceMode SamplerSource;
	public bool AutomaticViewMipBias;
	public byte ConstCoordinate;
	public int ConstMipValue;
}
