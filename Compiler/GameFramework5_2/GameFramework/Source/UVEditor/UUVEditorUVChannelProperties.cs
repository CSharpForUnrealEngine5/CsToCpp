#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Layer Settings for the UVEditorMode</summary>
[CppInclude("UVEditorModeChannelProperties.h")]
public partial class UUVEditorUVChannelProperties : UInteractiveToolPropertySet {
	///<summary>Asset</summary>
	public string Asset;
	///<summary>GetAssetNames</summary>
	public  TArray<string> GetAssetNames() { return default; }
	///<summary>UVChannel</summary>
	public string UVChannel;
	///<summary>GetUVChannelNames</summary>
	public  TArray<string> GetUVChannelNames() { return default; }
}
