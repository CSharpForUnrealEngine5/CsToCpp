#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ViewportStatsSubsystem.h")]
///<summary>The Viewport Stats Subsystem offers the ability to add messages to the current</summary>
public partial class UViewportStatsSubsystem : UWorldSubsystem {
// ViewportStatsSubsystem
	public void AddTimedDisplay(string Text,FLinearColor Color/*=FLinearColor.White*/,float Duration/*=0.0f*/,FVector2D DisplayOffset/*=FVector2D.ZeroVector*/) {}
	public int AddDisplayDelegate(FViewportDisplayCallback Delegate) { return default; }
	public void RemoveDisplayDelegate(int IndexToRemove) {}
}
