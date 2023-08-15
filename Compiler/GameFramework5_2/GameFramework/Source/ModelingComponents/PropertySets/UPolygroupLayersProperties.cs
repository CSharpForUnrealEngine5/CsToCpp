namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Basic Tool Property Set that allows for selecting from a list of FNames (that we assume are Polygroup Layers)</summary>
[CppInclude("PropertySets/PolygroupLayersProperties.h")]
public partial class UPolygroupLayersProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Select PolyGroup layer to use.</summary>
	public FName ActiveGroupLayer;
	///<summary>Provides set of available group layers</summary>
	public TArray<string> GetGroupLayersFunc() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> GroupLayersList;
}
