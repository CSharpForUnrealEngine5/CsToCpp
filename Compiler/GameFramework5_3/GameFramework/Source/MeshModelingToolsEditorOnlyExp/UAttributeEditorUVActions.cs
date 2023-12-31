namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorUVActions : UAttributeEditorActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>UVLayer</summary>
	public string UVLayer;
	///<summary>GetUVLayerNamesFunc</summary>
	public TArray<string> GetUVLayerNamesFunc() { return default; }
	///<summary>UVLayerNamesList</summary>
	public TArray<string> UVLayerNamesList;
	///<summary>Clear all UV layers, setting all UV values to (0,0)</summary>
	public void ClearAll() {}
	///<summary>Clear the selected UV layers, setting all UV values to (0,0)</summary>
	public void AddNew() {}
	///<summary>Clear the selected UV layers, setting all UV values to (0,0)</summary>
	public void DeleteSelected() {}
	///<summary>Clear the selected UV layers, setting all UV values to (0,0)</summary>
	public void DuplicateSelected() {}
}
