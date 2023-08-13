namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFSimpleButton.h")]
public partial class UUIFrameworkSimpleButton : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Text</summary>
	public FText Text;
	///<summary>ClickEvent</summary>
	public FUIFrameworkClickEventArgument ClickEvent;
	///<summary>SetText</summary>
	public void SetText(FText Value) {}
	///<summary>OnClick</summary>
	public void OnClick(FMVVMEventField Field) {}
	///<summary>OnRep_Text</summary>
	public void OnRep_Text() {}
	///<summary>ServerClick</summary>
	public void ServerClick(APlayerController PlayerController) {}
}
