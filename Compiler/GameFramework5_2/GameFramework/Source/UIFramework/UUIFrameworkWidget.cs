#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UIFWidget.h")]
public partial class UUIFrameworkWidget : UMVVMViewModelBase {
// UIFrameworkWidget
	public bool bIsEnabled;
	public ESlateVisibility Visibility;
	public void OnRep_IsEnabled() {}
	public void OnRep_Visibility() {}
	public TSoftObjectPtr<UClass> WidgetClass;
	public FUIFrameworkWidgetId Id;
	public object /*Wrapper*/ Wrapper;
	public FUIFrameworkParentWidget AuthorityParent;
	public UWidget LocalUMGWidget;
}
