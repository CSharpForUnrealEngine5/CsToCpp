#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VisualLogger/VisualLoggerKismetLibrary.h")]
public partial class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary {
// VisualLoggerKismetLibrary
	public static void EnableRecording(bool bEnabled) {}
	public static void RedirectVislog(UObject SourceOwner,UObject DestinationOwner) {}
	public static void LogText(UObject WorldContextObject,string Text,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	public static void LogLocation(UObject WorldContextObject,FVector Location,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,float Radius/*=10f*/,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	public static void LogBox(UObject WorldContextObject,FBox BoxShape,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	public static void LogSegment(UObject WorldContextObject,FVector SegmentStart,FVector SegmentEnd,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,float Thickness/*=0.0f*/,string CategoryName/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
}
