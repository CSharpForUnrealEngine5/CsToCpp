#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSobol.h")]
public partial class UMaterialExpressionSobol : UMaterialExpression {
// MaterialExpressionSobol
	public FExpressionInput Cell;
	public FExpressionInput Index;
	public FExpressionInput Seed;
	public uint ConstIndex;
	public FVector2D ConstSeed;
}
