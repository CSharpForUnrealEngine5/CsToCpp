#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionFractal3D.h")]
///<summary>Zero-centered 3D Fractal noise in 1, 2, 3 or 4 channels, created by summing several</summary>
public partial class UMaterialExpressionFractal3D : UMaterialExpression {
// MaterialExpressionFractal3D
	public FExpressionInput Position;
	public FExpressionInput Amplitude;
	public float ConstAmplitude;
	public FExpressionInput Octaves;
	public int ConstOctaves;
	public FExpressionInput Lacunarity;
	public float ConstLacunarity;
	public FExpressionInput Diminish;
	public float ConstDiminish;
	public float Scale;
	public bool bTurbulence;
	public int Levels;
	public float OutputMin;
	public float OutputMax;
}
