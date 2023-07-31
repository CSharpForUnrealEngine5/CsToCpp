#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for UDIMs in the UVEditor</summary>
[CppInclude("UVEditorMode.h")]
public partial class UUVEditorUDIMProperties : UInteractiveToolPropertySet {
	///<summary>UDIMSourceAsset</summary>
	public string UDIMSourceAsset;
	///<summary>GetAssetNames</summary>
	public  TArray<string> GetAssetNames() { return default; }
	///<summary>AssetByIndex</summary>
	public  int AssetByIndex() { return default; }
	///<summary>Set UDIM Layout from selected asset&#39;s UVs</summary>
	public  void SetUDIMsFromAsset() {}
	///<summary>Texture asset to source UDIM information from</summary>
	public UTexture2D UDIMSourceTexture;
	///<summary>Set UDIM Layout from selected texture asset</summary>
	public  void SetUDIMsFromTexture() {}
	///<summary>Currently active UDIM set</summary>
	public TArray<FUDIMSpecifier> ActiveUDIMs;
}
