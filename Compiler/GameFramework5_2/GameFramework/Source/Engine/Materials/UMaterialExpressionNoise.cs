#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionNoise.h")]
public partial class UMaterialExpressionNoise : UMaterialExpression {
// MaterialExpressionNoise
	public FExpressionInput Position;
	public FExpressionInput FilterWidth;
	public float Scale;
	public int Quality;
	public ENoiseFunction NoiseFunction;
	public bool bTurbulence;
	public int Levels;
	public float OutputMin;
	public float OutputMax;
	public float LevelScale;
	public bool bTiling;
	public uint RepeatSize;
}
