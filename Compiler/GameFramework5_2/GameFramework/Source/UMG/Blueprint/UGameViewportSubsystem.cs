#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/GameViewportSubsystem.h")]
public partial class UGameViewportSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>@return true if the widget was added to the viewport using AddWidget or AddWidgetForPlayer.</summary>
	public  bool IsWidgetAdded(UWidget Widget) { return default; }
	///<summary>Adds it to the game&#39;s viewport.</summary>
	public  void AddWidget(UWidget Widget,FGameViewportWidgetSlot Slot) {}
	///<summary>Adds the widget to the game&#39;s viewport in the section dedicated to the player. This is valuable in a split screen</summary>
	public  void AddWidgetForPlayer(UWidget Widget,ULocalPlayer Player,FGameViewportWidgetSlot Slot) {}
	///<summary>Removes the widget from the viewport.</summary>
	public  void RemoveWidget(UWidget Widget) {}
	///<summary>The slot info from previously added widget or info that is store for later.</summary>
	public  FGameViewportWidgetSlot GetWidgetSlot(UWidget Widget) { return default; }
	///<summary>Update the slot info of a previously added widget or Store the slot info for later use.</summary>
	public  void SetWidgetSlot(UWidget Widget,FGameViewportWidgetSlot Slot) {}
	///<summary>Helper function to set the position in the viewport for the Slot.</summary>
	public static FGameViewportWidgetSlot SetWidgetSlotPosition(FGameViewportWidgetSlot Slot,UWidget Widget,FVector2D Position,bool bRemoveDPIScale) { return default; }
	///<summary>Helper function to set the desired size in the viewport for the Slot.</summary>
	public static FGameViewportWidgetSlot SetWidgetSlotDesiredSize(FGameViewportWidgetSlot Slot,FVector2D Size) { return default; }
}
