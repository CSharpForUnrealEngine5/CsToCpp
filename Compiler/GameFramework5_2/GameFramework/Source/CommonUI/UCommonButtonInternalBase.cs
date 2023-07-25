#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonButtonBase.h")]
///<summary>Custom UButton override that allows us to disable clicking without disabling the widget entirely</summary>
public partial class UCommonButtonInternalBase : UButton {
// CommonButtonInternalBase
	public FOnButtonClickedEvent OnDoubleClicked;
	public int MinWidth;
	public int MinHeight;
	public bool bButtonEnabled;
	public bool bInteractionEnabled;
}
