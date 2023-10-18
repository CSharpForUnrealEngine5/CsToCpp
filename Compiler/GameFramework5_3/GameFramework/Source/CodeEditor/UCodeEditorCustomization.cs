namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeEditorCustomization.h")]
public partial class UCodeEditorCustomization : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Controls</summary>
	public TArray<FCodeEditorControlCustomization> Controls;
	///<summary>Text</summary>
	public TArray<FCodeEditorTextCustomization> Text;
}
