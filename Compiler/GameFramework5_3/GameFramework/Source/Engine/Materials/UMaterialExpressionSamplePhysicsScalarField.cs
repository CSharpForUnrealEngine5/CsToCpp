namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSamplePhysicsField.h")]
public partial class UMaterialExpressionSamplePhysicsScalarField : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to current world position if not specified</summary>
	public FExpressionInput WorldPosition;
	///<summary>Target Type to be accessed</summary>
	public EFieldScalarType FieldTarget;
}
