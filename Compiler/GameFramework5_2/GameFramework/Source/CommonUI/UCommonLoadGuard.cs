#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Load Guard behaves similarly to a Border, but with the ability to hide its primary content and display a loading spinner</summary>
[CppInclude("CommonLoadGuard.h")]
public partial class UCommonLoadGuard : UContentWidget {
	///<summary>SetLoadingText</summary>
	public  void SetLoadingText(string InLoadingText) {}
	///<summary>SetIsLoading</summary>
	public  void SetIsLoading(bool bInIsLoading) {}
	///<summary>IsLoading</summary>
	public  bool IsLoading() { return default; }
	///<summary>FOnAssetLoaded</summary>
	public  void FOnAssetLoaded(UObject Object) {}
	///<summary>bShowLoading</summary>
	public bool bShowLoading;
	///<summary>BP_GuardAndLoadAsset</summary>
	public  void BP_GuardAndLoadAsset(TSoftObjectPtr<UObject> InLazyAsset,FOnAssetLoaded OnAssetLoaded) {}
	///<summary>The background brush to display while loading the content</summary>
	public FSlateBrush LoadingBackgroundBrush;
	///<summary>The horizontal alignment of the loading throbber &amp; message</summary>
	public EHorizontalAlignment ThrobberAlignment;
	///<summary>The horizontal alignment of the loading throbber &amp; message</summary>
	public FMargin ThrobberPadding;
	///<summary>Loading message to display alongside the throbber</summary>
	public string LoadingText;
	///<summary>Style to apply to the loading message</summary>
	public UClass TextStyle;
	///<summary>BP_OnLoadingStateChanged</summary>
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
	///<summary>SpinnerMaterialPath</summary>
	public FSoftObjectPath SpinnerMaterialPath;
	///<summary>Used to track widgets that were created before changing the default style pointer to null</summary>
	public bool bStyleNoLongerNeedsConversion;
}
