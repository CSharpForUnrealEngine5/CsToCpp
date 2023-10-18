namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom UButton override that allows us to disable clicking without disabling the widget entirely</summary>
[CppInclude("CommonButtonBase.h")]
public partial class UCommonButtonInternalBase : UButton {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the button is clicked</summary>
	public FOnButtonClickedEvent OnDoubleClicked;
	///<summary>The minimum width of the button</summary>
	public int MinWidth;
	///<summary>The minimum height of the button</summary>
	public int MinHeight;
	///<summary>If true, this button is enabled.</summary>
	public bool bButtonEnabled;
	///<summary>If true, this button can be interacted with it normally. Otherwise, it will not react to being hovered or clicked.</summary>
	public bool bInteractionEnabled;
}
