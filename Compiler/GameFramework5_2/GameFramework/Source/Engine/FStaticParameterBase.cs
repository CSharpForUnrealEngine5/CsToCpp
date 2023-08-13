namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base parameter properties</summary>
[CppInclude("StaticParameterSet.h")]
public partial struct FStaticParameterBase {
	public FMaterialParameterInfo ParameterInfo;
	public bool bOverride;
	public FGuid ExpressionGUID;
}
