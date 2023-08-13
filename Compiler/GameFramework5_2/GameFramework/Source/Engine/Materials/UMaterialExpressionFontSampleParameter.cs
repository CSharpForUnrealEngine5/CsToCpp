namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFontSampleParameter.h")]
public partial class UMaterialExpressionFontSampleParameter : UMaterialExpressionFontSample {
	public static UClass StaticClass() {return default;}
	///<summary>name to be referenced when we want to find and set thsi parameter</summary>
	public string ParameterName;
	///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
	public FGuid ExpressionGUID;
	///<summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
	public string Group;
	///<summary>Controls where the this parameter is displayed in a material instance parameter list. The lower the number the higher up in the parameter list.</summary>
	public int SortPriority;
}
