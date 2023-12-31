namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFButton.h")]
public partial class UUIFrameworkButton : UUIFrameworkWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetContent</summary>
	public void SetContent(FUIFrameworkSimpleSlot Content) {}
	///<summary>GetContent</summary>
	public FUIFrameworkSimpleSlot GetContent() { return default; }
	///<summary>HandleClick</summary>
	public void HandleClick() {}
	///<summary>ServerClick</summary>
	public void ServerClick(APlayerController PlayerController) {}
	///<summary>OnRep_Slot</summary>
	public void OnRep_Slot() {}
	///<summary>ExposeOnSpawn,</summary>
	public FUIFrameworkSimpleSlot Slot;
}
