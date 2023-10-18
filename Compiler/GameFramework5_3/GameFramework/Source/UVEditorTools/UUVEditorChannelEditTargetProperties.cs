namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTargetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Asset</summary>
	public string Asset;
	///<summary>GetAssetNames</summary>
	public TArray<string> GetAssetNames() { return default; }
	///<summary>TargetChannel</summary>
	public string TargetChannel;
	///<summary>ReferenceChannel</summary>
	public string ReferenceChannel;
	///<summary>GetUVChannelNames</summary>
	public TArray<string> GetUVChannelNames() { return default; }
	///<summary>bActionNeedsAsset</summary>
	public bool bActionNeedsAsset;
	///<summary>bActionNeedsReference</summary>
	public bool bActionNeedsReference;
	///<summary>bActionNeedsTarget</summary>
	public bool bActionNeedsTarget;
}
