#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeTable.h")]
public partial class UCustomizableObjectNodeTable : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>Name of the property parameter</summary>
	public string ParameterName;
	///<summary>If true, adds a &quot;None&quot; parameter option</summary>
	public bool bAddNoneOption;
	///<summary>Pointer to the Data Table Asset represented in this node</summary>
	public UDataTable Table;
	///<summary>If there is a bool column in the table, checked rows will not be compiled</summary>
	public bool bDisableCheckedRows;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>Number of properties to know when the node needs an update</summary>
	public int NumProperties;
}
