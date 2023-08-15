namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertToPolygonsTool.h")]
public partial class UOutputPolygroupLayerProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Select PolyGroup layer to use.</summary>
	public FName GroupLayer;
	///<summary>Provides set of available group layers</summary>
	public TArray<string> GetGroupOptionsList() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> OptionsList;
	///<summary>bShowNewLayerName</summary>
	public bool bShowNewLayerName;
	///<summary>Name of the new Group Layer</summary>
	public string NewLayerName;
}
