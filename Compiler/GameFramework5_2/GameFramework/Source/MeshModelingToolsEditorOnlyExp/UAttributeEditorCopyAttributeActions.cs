namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorCopyAttributeActions : UAttributeEditorActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>FromAttribute</summary>
	public TArray<string> FromAttribute;
	///<summary>ToAttribute</summary>
	public TArray<string> ToAttribute;
	///<summary>CopyFromTo</summary>
	public void CopyFromTo() {}
}
