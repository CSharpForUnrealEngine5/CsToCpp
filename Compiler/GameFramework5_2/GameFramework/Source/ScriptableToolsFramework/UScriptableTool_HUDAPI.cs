namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableTool_HUDAPI is helper Object that is created internally by a UScriptableInteractiveTool</summary>
[CppInclude("ScriptableInteractiveTool.h")]
public partial class UScriptableTool_HUDAPI : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DrawTextAtLocation</summary>
	public UScriptableTool_HUDAPI DrawTextAtLocation(FVector Location,string String,FLinearColor Color,bool bCentered,float ShiftRowsY) { return default; }
	///<summary>DrawTextArrayAtLocation</summary>
	public UScriptableTool_HUDAPI DrawTextArrayAtLocation(FVector Location,TArray<string> Strings,FLinearColor Color,bool bCentered,float ShiftRowsY) { return default; }
	///<summary>GetCanvasLocation</summary>
	public UScriptableTool_HUDAPI GetCanvasLocation(FVector Location,FVector2D CanvasLocation) { return default; }
}
