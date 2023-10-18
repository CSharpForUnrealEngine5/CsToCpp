namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable vector parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FVectorParameterValue {
	public FName ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public FLinearColor ParameterValue;
	public FGuid ExpressionGUID;
}
