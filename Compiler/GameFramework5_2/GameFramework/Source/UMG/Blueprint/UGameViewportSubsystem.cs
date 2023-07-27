#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/GameViewportSubsystem.h")]
public partial class UGameViewportSubsystem : UEngineSubsystem {
// GameViewportSubsystem
	public  bool IsWidgetAdded(UWidget Widget) { return default; }
	public  void AddWidget(UWidget Widget,FGameViewportWidgetSlot Slot) {}
	public  void AddWidgetForPlayer(UWidget Widget,ULocalPlayer Player,FGameViewportWidgetSlot Slot) {}
	public  void RemoveWidget(UWidget Widget) {}
	public  FGameViewportWidgetSlot GetWidgetSlot(UWidget Widget) { return default; }
	public  void SetWidgetSlot(UWidget Widget,FGameViewportWidgetSlot Slot) {}
	public static FGameViewportWidgetSlot SetWidgetSlotPosition(FGameViewportWidgetSlot Slot,UWidget Widget,FVector2D Position,bool bRemoveDPIScale) { return default; }
	public static FGameViewportWidgetSlot SetWidgetSlotDesiredSize(FGameViewportWidgetSlot Slot,FVector2D Size) { return default; }
}
