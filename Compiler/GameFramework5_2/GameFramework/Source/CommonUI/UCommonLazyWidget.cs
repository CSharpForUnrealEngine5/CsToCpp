#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A special Image widget that can show unloaded images and takes care of the loading for you!</summary>
[CppInclude("CommonLazyWidget.h")]
public partial class UCommonLazyWidget : UWidget {
	///<summary>SetLazyContent</summary>
	public  void SetLazyContent(TSoftObjectPtr<UClass> SoftWidget) {}
	///<summary>GetContent</summary>
	public  UUserWidget GetContent() { return default; }
	///<summary>IsLoading</summary>
	public  bool IsLoading() { return default; }
	///<summary>LoadingBackgroundBrush</summary>
	public FSlateBrush LoadingBackgroundBrush;
	///<summary>Content</summary>
	public UUserWidget Content;
	///<summary>BP_OnLoadingStateChanged</summary>
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
}
