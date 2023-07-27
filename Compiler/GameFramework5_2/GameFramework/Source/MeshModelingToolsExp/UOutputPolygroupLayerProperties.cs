#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UOutputPolygroupLayerProperties : UInteractiveToolPropertySet {
// OutputPolygroupLayerProperties
	public string GroupLayer;
	public  TArray<string> GetGroupOptionsList() { return default; }
	public TArray<string> OptionsList;
	public bool bShowNewLayerName;
	public string NewLayerName;
}
