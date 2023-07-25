#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorMode.h")]
///<summary>Settings for UDIMs in the UVEditor</summary>
public partial class UUVEditorUDIMProperties : UInteractiveToolPropertySet {
// UVEditorUDIMProperties
	public string UDIMSourceAsset;
	public TArray<string> GetAssetNames() { return default; }
	public int AssetByIndex() { return default; }
	public void SetUDIMsFromAsset() {}
	public UTexture2D UDIMSourceTexture;
	public void SetUDIMsFromTexture() {}
	public TArray<FUDIMSpecifier> ActiveUDIMs;
}
