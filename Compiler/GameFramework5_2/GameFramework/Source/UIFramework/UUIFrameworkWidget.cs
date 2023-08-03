#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UIFWidget.h")]
public partial class UUIFrameworkWidget : UMVVMViewModelBase {
	public static UClass StaticClass() {return default;}
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
	///<summary>Visibility</summary>
	public ESlateVisibility Visibility;
	///<summary>OnRep_IsEnabled</summary>
	public  void OnRep_IsEnabled() {}
	///<summary>OnRep_Visibility</summary>
	public  void OnRep_Visibility() {}
	///<summary>WidgetClass</summary>
	public TSoftObjectPtr<UClass> WidgetClass;
	///<summary>Id</summary>
	public FUIFrameworkWidgetId Id;
	///<summary>Wrapper</summary>
	public object /*Wrapper*/ Wrapper;
	///<summary>AuthorityParent</summary>
	public FUIFrameworkParentWidget AuthorityParent;
	///<summary>LocalUMGWidget</summary>
	public UWidget LocalUMGWidget;
}
