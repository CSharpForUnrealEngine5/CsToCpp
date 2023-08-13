namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The default value fills the entire screen / player region.</summary>
[CppInclude("Blueprint/GameViewportSubsystem.h")]
public partial struct FGameViewportWidgetSlot {
	public FAnchors Anchors;
	public FMargin Offsets;
	public FVector2D Alignment;
	public int ZOrder;
}
