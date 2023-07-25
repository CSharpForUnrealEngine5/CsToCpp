#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFSimpleButton.h")]
public partial class UUIFrameworkSimpleButton : UUIFrameworkWidget {
// UIFrameworkSimpleButton
	public string Text;
	public FUIFrameworkClickEventArgument ClickEvent;
	public void SetText(string Value) {}
	public void OnClick(FMVVMEventField Field) {}
	public void OnRep_Text() {}
	public void ServerClick(UObject PlayerController) {}
}
