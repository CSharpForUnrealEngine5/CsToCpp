#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable font parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FFontParameterValue {
	public string ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public UFont FontValue;
	public int FontPage;
	public FGuid ExpressionGUID;
}
