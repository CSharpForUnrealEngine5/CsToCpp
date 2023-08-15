namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@warning: FExpressionInput is mirrored in MaterialShared.h and manually &quot;subclassed&quot; in Material.h (FMaterialInput)</summary>
[CppInclude("Materials/MaterialExpression.h")]
public partial struct FExpressionInput {
	public UMaterialExpression Expression;
	public int OutputIndex;
	public FName InputName;
	public int Mask;
	public int MaskR;
	public int MaskG;
	public int MaskB;
	public int MaskA;
}
