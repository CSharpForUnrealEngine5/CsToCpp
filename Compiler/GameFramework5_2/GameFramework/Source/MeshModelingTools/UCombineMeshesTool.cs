#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CombineMeshesTool.h")]
///<summary>Simple tool to combine multiple meshes into a single mesh asset</summary>
public partial class UCombineMeshesTool : UMultiSelectionMeshEditingTool {
// CombineMeshesTool
	public UCombineMeshesToolProperties BasicProperties;
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public UOnAcceptHandleSourcesPropertiesBase HandleSourceProperties;
}
