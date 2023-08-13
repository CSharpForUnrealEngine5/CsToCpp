namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTexturePaintingTool.h")]
public partial class UMeshTexturePaintingToolProperties : UBrushBaseProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Color used for Applying Texture Color Painting</summary>
	public FLinearColor PaintColor;
	///<summary>Color used for Erasing Texture Color Painting</summary>
	public FLinearColor EraseColor;
	///<summary>Whether or not to apply Texture Color Painting to the Red Channel</summary>
	public bool bWriteRed;
	///<summary>Whether or not to apply Texture Color Painting to the Green Channel</summary>
	public bool bWriteGreen;
	///<summary>Whether or not to apply Texture Color Painting to the Blue Channel</summary>
	public bool bWriteBlue;
	///<summary>Whether or not to apply Texture Color Painting to the Alpha Channel</summary>
	public bool bWriteAlpha;
	///<summary>UV channel which should be used for paint textures</summary>
	public int UVChannel;
	///<summary>Seam painting flag, True if we should enable dilation to allow the painting of texture seams</summary>
	public bool bEnableSeamPainting;
	///<summary>Texture to which Painting should be Applied</summary>
	public UTexture2D PaintTexture;
	///<summary>Enables &quot;Flow&quot; painting where paint is continually applied from the brush every tick</summary>
	public bool bEnableFlow;
	///<summary>Whether back-facing triangles should be ignored</summary>
	public bool bOnlyFrontFacingTriangles;
}
