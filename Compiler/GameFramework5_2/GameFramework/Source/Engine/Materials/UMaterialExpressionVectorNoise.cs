#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionVectorNoise.h")]
public partial class UMaterialExpressionVectorNoise : UMaterialExpression {
// MaterialExpressionVectorNoise
	public FExpressionInput Position;
	public byte NoiseFunction;
	public int Quality;
	public bool bTiling;
	public uint TileSize;
}
