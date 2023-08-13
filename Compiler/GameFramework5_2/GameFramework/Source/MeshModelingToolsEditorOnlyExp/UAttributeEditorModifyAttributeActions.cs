namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorModifyAttributeActions : UAttributeEditorActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Attribute</summary>
	public string Attribute;
	///<summary>GetAttributeNamesFunc</summary>
	public TArray<string> GetAttributeNamesFunc() { return default; }
	///<summary>AttributeNamesList</summary>
	public TArray<string> AttributeNamesList;
	///<summary>Remove the selected Attribute Name from the mesh</summary>
	public void DeleteSelected() {}
}
