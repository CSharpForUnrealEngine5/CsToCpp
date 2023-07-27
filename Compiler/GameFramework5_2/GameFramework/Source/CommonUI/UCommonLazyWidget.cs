#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonLazyWidget.h")]
///<summary>A special Image widget that can show unloaded images and takes care of the loading for you!</summary>
public partial class UCommonLazyWidget : UWidget {
// CommonLazyWidget
	public  void SetLazyContent(TSoftObjectPtr<UClass> SoftWidget) {}
	public  UUserWidget GetContent() { return default; }
	public  bool IsLoading() { return default; }
	public FSlateBrush LoadingBackgroundBrush;
	public UUserWidget Content;
	public FOnLoadGuardStateChangedDynamic BP_OnLoadingStateChanged;
}
