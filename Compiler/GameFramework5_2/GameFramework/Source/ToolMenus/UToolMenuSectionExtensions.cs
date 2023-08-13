namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolMenusBlueprintLibrary.h")]
public partial class UToolMenuSectionExtensions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SetLabel</summary>
	public static void SetLabel(FToolMenuSection Section,FText Label) {}
	///<summary>GetLabel</summary>
	public static FText GetLabel(FToolMenuSection Section) { return default; }
	///<summary>AddEntry</summary>
	public static void AddEntry(FToolMenuSection Section,FToolMenuEntry Args) {}
	///<summary>AddEntryObject</summary>
	public static void AddEntryObject(FToolMenuSection Section,UToolMenuEntryScript InObject) {}
}
