namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAlignObjectsTool transforms the input Components so that they are aligned in various ways, depending on the current settings.</summary>
[CppInclude("AlignObjectsTool.h")]
public partial class UAlignObjectsTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>AlignProps</summary>
	public UAlignObjectsToolProperties AlignProps;
}
