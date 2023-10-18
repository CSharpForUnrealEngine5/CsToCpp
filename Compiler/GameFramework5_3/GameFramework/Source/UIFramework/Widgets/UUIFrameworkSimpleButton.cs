namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFSimpleButton.h")]
public partial class UUIFrameworkSimpleButton : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Text</summary>
	public FText Text;
	///<summary>Message</summary>
	public FLocalizableMessage Message;
	///<summary>ClickEvent</summary>
	public FUIFrameworkClickEventArgument ClickEvent;
	///<summary>OnClick</summary>
	public void OnClick(FMVVMEventField Field) {}
	///<summary>OnRep_Message</summary>
	public void OnRep_Message() {}
	///<summary>ServerClick</summary>
	public void ServerClick(APlayerController PlayerController) {}
}
