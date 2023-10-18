namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings that control Slate functionality</summary>
[CppInclude("SlateSettings.h")]
public partial class USlateSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Allow children of SConstraintCanvas to share render layers. Children must set explicit ZOrder on their slots to control render order.</summary>
	public bool bExplicitCanvasChildZOrder;
}
