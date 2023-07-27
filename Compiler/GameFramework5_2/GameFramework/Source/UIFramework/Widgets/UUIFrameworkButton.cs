#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFButton.h")]
public partial class UUIFrameworkButton : UUIFrameworkWidget {
// UIFrameworkButton
	public  void SetContent(FUIFrameworkSimpleSlot Content) {}
	public  FUIFrameworkSimpleSlot GetContent() { return default; }
	public  void HandleClick() {}
	public  void ServerClick(APlayerController PlayerController) {}
	public  void OnRep_Slot() {}
	public FUIFrameworkSimpleSlot Slot;
}
