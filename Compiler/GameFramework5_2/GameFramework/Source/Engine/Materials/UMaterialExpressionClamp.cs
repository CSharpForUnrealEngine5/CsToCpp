#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionClamp.h")]
public partial class UMaterialExpressionClamp : UMaterialExpression {
// MaterialExpressionClamp
	public FExpressionInput Input;
	public FExpressionInput Min;
	public FExpressionInput Max;
	public byte ClampMode;
	public float MinDefault;
	public float MaxDefault;
}
