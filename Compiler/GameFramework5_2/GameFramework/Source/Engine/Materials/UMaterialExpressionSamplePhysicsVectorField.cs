#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material expresions to sample the global field</summary>
[CppInclude("Materials/MaterialExpressionSamplePhysicsField.h")]
public partial class UMaterialExpressionSamplePhysicsVectorField : UMaterialExpression {
	///<summary>Defaults to current world position if not specified</summary>
	public FExpressionInput WorldPosition;
	///<summary>Target Type to be accessed</summary>
	public EFieldVectorType FieldTarget;
}
