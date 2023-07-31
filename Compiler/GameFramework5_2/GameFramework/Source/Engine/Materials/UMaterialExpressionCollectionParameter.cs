#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCollectionParameter.h")]
public partial class UMaterialExpressionCollectionParameter : UMaterialExpression {
	///<summary>The Parameter Collection to use.</summary>
	public UMaterialParameterCollection Collection;
	///<summary>Name of the parameter being referenced.</summary>
	public string ParameterName;
	///<summary>Id that is set from the name, and used to handle renaming of collection parameters.</summary>
	public FGuid ParameterId;
}
