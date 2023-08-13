namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VisualLogger/VisualLoggerKismetLibrary.h")]
public partial class UVisualLoggerKismetLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>EnableRecording</summary>
	public static void EnableRecording(bool bEnabled) {}
	///<summary>Makes SourceOwner log to DestinationOwner&#39;s vislog</summary>
	public static void RedirectVislog(UObject SourceOwner,UObject DestinationOwner) {}
	///<summary>Logs simple text string with Visual Logger - recording for Visual Logs has to be enabled to record this data</summary>
	public static void LogText(UObject WorldContextObject,string Text,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	///<summary>Logs location as sphere with given radius - recording for Visual Logs has to be enabled to record this data</summary>
	public static void LogLocation(UObject WorldContextObject,FVector Location,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,float Radius/*=10f*/,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	///<summary>Logs box shape - recording for Visual Logs has to be enabled to record this data</summary>
	public static void LogBox(UObject WorldContextObject,FBox BoxShape,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,string LogCategory/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
	///<summary>LogSegment</summary>
	public static void LogSegment(UObject WorldContextObject,FVector SegmentStart,FVector SegmentEnd,string Text,FLinearColor ObjectColor/*=FLinearColor.Blue*/,float Thickness/*=0.0f*/,string CategoryName/*=TEXT("VisLogBP")*/,bool bAddToMessageLog/*=false*/) {}
}
