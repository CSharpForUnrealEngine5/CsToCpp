#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/DEditorParameterValue.h")]
public partial class UDEditorParameterValue : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bOverride</summary>
	public bool bOverride;
	///<summary>ParameterInfo</summary>
	public FMaterialParameterInfo ParameterInfo;
	///<summary>ExpressionId</summary>
	public FGuid ExpressionId;
	///<summary>Description</summary>
	public string Description;
	///<summary>AssetPath</summary>
	public string AssetPath;
	///<summary>Controls where this parameter is displayed in a material instance parameter list.  The lower the number the higher up in the parameter list.</summary>
	public int SortPriority;
}
