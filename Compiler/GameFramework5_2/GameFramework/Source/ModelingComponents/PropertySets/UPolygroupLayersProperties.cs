#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/PolygroupLayersProperties.h")]
///<summary>Basic Tool Property Set that allows for selecting from a list of FNames (that we assume are Polygroup Layers)</summary>
public partial class UPolygroupLayersProperties : UInteractiveToolPropertySet {
// PolygroupLayersProperties
	public string ActiveGroupLayer;
	public TArray<string> GetGroupLayersFunc() { return default; }
	public TArray<string> GroupLayersList;
}
