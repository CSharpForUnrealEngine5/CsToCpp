namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable font parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FFontParameterValue {
	public FName ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public UFont FontValue;
	public int FontPage;
	public FGuid ExpressionGUID;
}
