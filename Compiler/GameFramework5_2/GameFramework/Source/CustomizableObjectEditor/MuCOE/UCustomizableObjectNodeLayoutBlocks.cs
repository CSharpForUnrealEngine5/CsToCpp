#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeLayoutBlocks.h")]
public partial class UCustomizableObjectNodeLayoutBlocks : UCustomizableObjectNode {
	///<summary>GridSize_DEPRECATED</summary>
	public FIntPoint GridSize_DEPRECATED;
	///<summary>Used with the fixed layout strategy.</summary>
	public FIntPoint MaxGridSize_DEPRECATED;
	///<summary>Blocks_DEPRECATED</summary>
	public TArray<FCustomizableObjectLayoutBlock> Blocks_DEPRECATED;
	///<summary>PackingStrategy_DEPRECATED</summary>
	public ECustomizableObjectTextureLayoutPackingStrategy PackingStrategy_DEPRECATED;
	///<summary>Layout</summary>
	public UCustomizableObjectLayout Layout;
}
