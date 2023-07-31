#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFSimpleButton.h")]
public partial class UUIFrameworkSimpleButton : UUIFrameworkWidget {
	///<summary>Text</summary>
	public string Text;
	///<summary>ClickEvent</summary>
	public FUIFrameworkClickEventArgument ClickEvent;
	///<summary>SetText</summary>
	public  void SetText(string Value) {}
	///<summary>OnClick</summary>
	public  void OnClick(FMVVMEventField Field) {}
	///<summary>OnRep_Text</summary>
	public  void OnRep_Text() {}
	///<summary>ServerClick</summary>
	public  void ServerClick(APlayerController PlayerController) {}
}
