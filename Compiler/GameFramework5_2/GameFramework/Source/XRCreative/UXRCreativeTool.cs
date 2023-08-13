namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativeTool : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetToolName</summary>
	public virtual string GetToolName() { return default; }
	///<summary>GetDisplayName</summary>
	public virtual FText GetDisplayName() { return default; }
	///<summary>GetPaletteTabClass</summary>
	public virtual UClass GetPaletteTabClass() { return default; }
}
