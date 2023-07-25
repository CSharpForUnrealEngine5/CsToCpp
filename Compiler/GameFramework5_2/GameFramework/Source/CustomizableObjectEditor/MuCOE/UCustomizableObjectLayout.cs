#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectLayout.h")]
public partial class UCustomizableObjectLayout : UObject {
// CustomizableObjectLayout
	public TArray<FCustomizableObjectLayoutBlock> Blocks;
	public UObject Mesh;
	public int LOD;
	public int Material;
	public int UVChannel;
	public FIntPoint GridSize;
	public FIntPoint MaxGridSize;
	public ECustomizableObjectTextureLayoutPackingStrategy PackingStrategy;
	public string LayoutName;
}
