#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorModifyAttributeActions : UAttributeEditorActionPropertySet {
	///<summary>Attribute</summary>
	public string Attribute;
	///<summary>GetAttributeNamesFunc</summary>
	public  TArray<string> GetAttributeNamesFunc() { return default; }
	///<summary>AttributeNamesList</summary>
	public TArray<string> AttributeNamesList;
	///<summary>Remove the selected Attribute Name from the mesh</summary>
	public  void DeleteSelected() {}
}
