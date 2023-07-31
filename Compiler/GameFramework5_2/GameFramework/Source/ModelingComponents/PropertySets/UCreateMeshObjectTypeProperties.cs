#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCreateMeshObjectTypeProperties is a InteractiveTool PropertySet used to select</summary>
[CppInclude("PropertySets/CreateMeshObjectTypeProperties.h")]
public partial class UCreateMeshObjectTypeProperties : UInteractiveToolPropertySet {
	///<summary>Type of object to create</summary>
	public string OutputType;
	///<summary>Type of volume to create</summary>
	public UClass VolumeType;
	///<summary>This function returns a list that is shown to select OutputType</summary>
	public  TArray<string> GetOutputTypeNamesFunc() { return default; }
	///<summary>The list returned by GetOutputTypeNamesFunc()</summary>
	public TArray<string> OutputTypeNamesList;
	///<summary>control whether the VolumeType field is enabled</summary>
	public bool bShowVolumeList;
	///<summary>@return true if we should show this property set on a Tool, ie if there are options the user can actually change (false if only one possible output type that has no options)</summary>
	public  bool ShouldShowPropertySet() { return default; }
	///<summary>Convert current OutputType selection into a type that can be passed to UModelingObjectsCreationAPI</summary>
	public  ECreateObjectTypeHint GetCurrentCreateMeshType() { return default; }
}
