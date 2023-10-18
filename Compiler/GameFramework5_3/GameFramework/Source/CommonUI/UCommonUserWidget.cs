namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUserWidget.h")]
public partial class UCommonUserWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Sets whether or not this widget will consume ALL pointer input that reaches it</summary>
	public void SetConsumePointerInput(bool bInConsumePointerInput) {}
	///<summary>True to generally display this widget&#39;s actions in the action bar, assuming it has actions.</summary>
	public bool bDisplayInActionBar;
	///<summary>Set this to true if you don&#39;t want any pointer (mouse and touch) input to bubble past this widget</summary>
	public bool bConsumePointerInput;
}
