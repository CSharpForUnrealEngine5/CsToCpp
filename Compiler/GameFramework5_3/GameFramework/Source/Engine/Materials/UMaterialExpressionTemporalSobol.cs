namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTemporalSobol.h")]
public partial class UMaterialExpressionTemporalSobol : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Sobol point number. Use Const Index if not connected.</summary>
	public FExpressionInput Index;
	///<summary>2D Seed for sequence randomization (0,0)-(1,1). Use Const Seed if not connected.</summary>
	public FExpressionInput Seed;
	///<summary>Sobol point number. Only used if Index is not connected.</summary>
	public uint ConstIndex;
	///<summary>2D Seed for sequence randomization. Only used if Seed is not connected.</summary>
	public FVector2D ConstSeed;
}
