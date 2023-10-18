namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStaticBoolParameter.h")]
public partial class UMaterialExpressionStaticBoolParameter : UMaterialExpressionParameter {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public bool DefaultValue;
	///<summary>Change Parameter from &quot;static bool&quot; to (dynamic) bool type which enables it to be used with dynamic branching</summary>
	public bool DynamicBranch;
}
