#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshUVChannelProperties.h")]
public partial class UMeshUVChannelProperties : UInteractiveToolPropertySet {
	///<summary>Select UV channel in the mesh</summary>
	public string UVChannel;
	///<summary>GetUVChannelNamesFunc</summary>
	public  TArray<string> GetUVChannelNamesFunc() { return default; }
	///<summary>UVChannelNamesList</summary>
	public TArray<string> UVChannelNamesList;
}
