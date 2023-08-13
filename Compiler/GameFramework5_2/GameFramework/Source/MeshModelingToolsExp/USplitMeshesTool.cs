namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SplitMeshesTool.h")]
public partial class USplitMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public USplitMeshesToolProperties BasicProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
}
