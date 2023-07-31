#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureSampleParameter.h")]
public partial class UMaterialExpressionTextureSampleParameter : UMaterialExpressionTextureSample {
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
	public FGuid ExpressionGUID;
	///<summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
	public string Group;
	///<summary>Controls where the this parameter is displayed in a material instance parameter list.  The lower the number the higher up in the parameter list.</summary>
	public int SortPriority;
	///<summary>ChannelNames</summary>
	public FParameterChannelNames ChannelNames;
}
