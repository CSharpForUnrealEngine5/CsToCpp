namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCollectionParameter.h")]
public partial class UMaterialExpressionCollectionParameter : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The Parameter Collection to use.</summary>
	public UMaterialParameterCollection Collection;
	///<summary>Name of the parameter being referenced.</summary>
	public FName ParameterName;
	///<summary>Id that is set from the name, and used to handle renaming of collection parameters.</summary>
	public FGuid ParameterId;
}
