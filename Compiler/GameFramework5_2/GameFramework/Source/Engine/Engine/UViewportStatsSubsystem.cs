namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Viewport Stats Subsystem offers the ability to add messages to the current</summary>
[CppInclude("Engine/ViewportStatsSubsystem.h")]
public partial class UViewportStatsSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Add a message to be displayed on the viewport of this world</summary>
	public void AddTimedDisplay(FText Text,FLinearColor Color/*=FLinearColor.White*/,float Duration/*=0.0f*/,FVector2D DisplayOffset/*=FVector2D.ZeroVector*/) {}
	///<summary>Add a dynamic delegate to the display subsystem.</summary>
	public int AddDisplayDelegate(FViewportDisplayCallback Delegate) { return default; }
	///<summary>Remove a callback function from the display subsystem</summary>
	public void RemoveDisplayDelegate(int IndexToRemove) {}
}
