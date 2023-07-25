#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpression.h")]
///<summary>@warning: FExpressionInput is mirrored in MaterialShared.h and manually "subclassed" in Material.h (FMaterialInput)</summary>
public partial struct FExpressionInput {
// ExpressionInput
	public UMaterialExpression Expression;
	public int OutputIndex;
	public string InputName;
	public int Mask;
	public int MaskR;
	public int MaskG;
	public int MaskB;
	public int MaskA;
}
