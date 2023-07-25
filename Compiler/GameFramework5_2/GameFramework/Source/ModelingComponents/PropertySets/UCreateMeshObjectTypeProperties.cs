#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/CreateMeshObjectTypeProperties.h")]
///<summary>UCreateMeshObjectTypeProperties is a InteractiveTool PropertySet used to select</summary>
public partial class UCreateMeshObjectTypeProperties : UInteractiveToolPropertySet {
// CreateMeshObjectTypeProperties
	public string OutputType;
	public UClass VolumeType;
	public TArray<string> GetOutputTypeNamesFunc() { return default; }
	public TArray<string> OutputTypeNamesList;
	public bool bShowVolumeList;
	public bool ShouldShowPropertySet() { return default; }
	public ECreateObjectTypeHint GetCurrentCreateMeshType() { return default; }
}
