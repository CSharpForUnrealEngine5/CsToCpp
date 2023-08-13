namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instance UMVVMClassExtension_View for the UUserWdiget</summary>
[CppInclude("View/MVVMView.h")]
public partial class UMVVMView : UUserWidgetExtension {
	public static UClass StaticClass() {return default;}
	///<summary>UFUNCTION(BlueprintCallable, Category = &quot;MVVM&quot;)</summary>
	public bool SetViewModel(string ViewModelName,object /*ViewModel*/ ViewModel) { return default; }
	///<summary>ClassExtension</summary>
	public UMVVMViewClass ClassExtension;
}
