#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTargetProperties : UInteractiveToolPropertySet {
// UVEditorChannelEditTargetProperties
	public string Asset;
	public  TArray<string> GetAssetNames() { return default; }
	public string TargetChannel;
	public string ReferenceChannel;
	public  TArray<string> GetUVChannelNames() { return default; }
	public bool bActionNeedsAsset;
	public bool bActionNeedsReference;
	public bool bActionNeedsTarget;
}
