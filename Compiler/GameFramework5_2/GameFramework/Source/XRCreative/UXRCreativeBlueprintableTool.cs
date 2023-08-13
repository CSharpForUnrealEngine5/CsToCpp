namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativeBlueprintableTool : UXRCreativeTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolName</summary>
	public string ToolName;
	///<summary>DisplayName</summary>
	public FText DisplayName;
	///<summary>PaletteTabClass</summary>
	public UClass PaletteTabClass;
	///<summary>ToolActor</summary>
	public UClass ToolActor;
	///<summary>ToolInputMappingContext</summary>
	public UInputMappingContext ToolInputMappingContext;
}
