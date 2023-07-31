#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionRuntimeVirtualTextureSampleParameter.h")]
public partial class UMaterialExpressionRuntimeVirtualTextureSampleParameter : UMaterialExpressionRuntimeVirtualTextureSample {
	///<summary>Name to be referenced when we want to find and set this parameter</summary>
	public string ParameterName;
	///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
	public FGuid ExpressionGUID;
	///<summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
	public string Group;
	///<summary>Controls where the this parameter is displayed in a material instance parameter list. The lower the number the higher up in the parameter list.</summary>
	public int SortPriority;
}
