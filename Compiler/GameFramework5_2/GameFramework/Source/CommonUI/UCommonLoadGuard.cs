#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonLoadGuard.h")]
///<summary>The Load Guard behaves similarly to a Border, but with the ability to hide its primary content and display a loading spinner</summary>
public partial class UCommonLoadGuard : UContentWidget {
// CommonLoadGuard
	public  void SetLoadingText(string InLoadingText) {}
	public  void SetIsLoading(bool bInIsLoading) {}
	public  bool IsLoading() { return default; }
	public  void FOnAssetLoaded(UObject Object) {}
	public bool bShowLoading;
	public  void BP_GuardAndLoadAsset(TSoftObjectPtr<UObject> InLazyAsset,FOnAssetLoaded OnAssetLoaded) {}
	public FSlateBrush LoadingBackgroundBrush;
	public byte ThrobberAlignment;
	public FMargin ThrobberPadding;
	public string LoadingText;
	public UClass TextStyle;
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
	public FSoftObjectPath SpinnerMaterialPath;
	public bool bStyleNoLongerNeedsConversion;
}
