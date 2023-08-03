#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativeBlueprintableTool : UXRCreativeTool {
	public static UClass StaticClass() {return default;}
	///<summary>ToolName</summary>
	public string ToolName;
	///<summary>DisplayName</summary>
	public string DisplayName;
	///<summary>PaletteTabClass</summary>
	public UClass PaletteTabClass;
	///<summary>ToolActor</summary>
	public UClass ToolActor;
	///<summary>ToolInputMappingContext</summary>
	public UInputMappingContext ToolInputMappingContext;
}
