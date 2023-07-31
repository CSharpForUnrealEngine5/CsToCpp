#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UOutputPolygroupLayerProperties : UInteractiveToolPropertySet {
	///<summary>Select PolyGroup layer to use.</summary>
	public string GroupLayer;
	///<summary>Provides set of available group layers</summary>
	public  TArray<string> GetGroupOptionsList() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> OptionsList;
	///<summary>bShowNewLayerName</summary>
	public bool bShowNewLayerName;
	///<summary>Name of the new Group Layer</summary>
	public string NewLayerName;
}
