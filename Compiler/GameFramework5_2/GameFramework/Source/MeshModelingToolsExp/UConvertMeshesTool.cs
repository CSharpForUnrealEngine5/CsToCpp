namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConvertMeshesTool.h")]
public partial class UConvertMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UConvertMeshesToolProperties BasicProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
}
