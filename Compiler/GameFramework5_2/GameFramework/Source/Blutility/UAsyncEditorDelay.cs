namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityLibrary.h")]
public partial class UAsyncEditorDelay : UEditorUtilityBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>AsyncEditorDelay</summary>
	public static UAsyncEditorDelay AsyncEditorDelay(float Seconds,int MinimumFrames/*=30*/) { return default; }
	///<summary>Complete</summary>
	public FAsyncDelayComplete Complete;
}
