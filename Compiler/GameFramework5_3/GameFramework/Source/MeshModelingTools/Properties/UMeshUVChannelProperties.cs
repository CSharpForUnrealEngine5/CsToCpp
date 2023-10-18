namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/MeshUVChannelProperties.h")]
public partial class UMeshUVChannelProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Select UV channel in the mesh</summary>
	public string UVChannel;
	///<summary>GetUVChannelNamesFunc</summary>
	public TArray<string> GetUVChannelNamesFunc() { return default; }
	///<summary>UVChannelNamesList</summary>
	public TArray<string> UVChannelNamesList;
}
