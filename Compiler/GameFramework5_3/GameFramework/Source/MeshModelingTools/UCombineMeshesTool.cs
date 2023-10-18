namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple tool to combine multiple meshes into a single mesh asset</summary>
[CppInclude("CombineMeshesTool.h")]
public partial class UCombineMeshesTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UCombineMeshesToolProperties BasicProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>HandleSourceProperties</summary>
	public UOnAcceptHandleSourcesPropertiesBase HandleSourceProperties;
}
