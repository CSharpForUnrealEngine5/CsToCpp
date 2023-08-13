namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Layer Settings for the UVEditorMode</summary>
[CppInclude("UVEditorModeChannelProperties.h")]
public partial class UUVEditorUVChannelProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Asset</summary>
	public string Asset;
	///<summary>GetAssetNames</summary>
	public TArray<string> GetAssetNames() { return default; }
	///<summary>UVChannel</summary>
	public string UVChannel;
	///<summary>GetUVChannelNames</summary>
	public TArray<string> GetUVChannelNames() { return default; }
}
