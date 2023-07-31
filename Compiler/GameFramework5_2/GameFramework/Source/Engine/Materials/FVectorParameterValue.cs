#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable vector parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FVectorParameterValue {
	public string ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public FLinearColor ParameterValue;
	public FGuid ExpressionGUID;
}
