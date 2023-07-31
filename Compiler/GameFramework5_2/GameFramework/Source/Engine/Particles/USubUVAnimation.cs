#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SubUV animation asset, which caches bounding geometry for regions in the SubUVTexture with non-zero opacity.</summary>
[CppInclude("Particles/SubUVAnimation.h")]
public partial class USubUVAnimation : UObject {
	///<summary>Texture to generate bounding geometry from.</summary>
	public UTexture2D SubUVTexture;
	///<summary>The number of sub-images horizontally in the texture</summary>
	public int SubImages_Horizontal;
	///<summary>The number of sub-images vertically in the texture</summary>
	public int SubImages_Vertical;
	///<summary>More bounding vertices results in reduced overdraw, but adds more triangle overhead.</summary>
	public ESubUVBoundingVertexCount BoundingMode;
	///<summary>OpacitySourceMode</summary>
	public EOpacitySourceMode OpacitySourceMode;
	///<summary>Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.</summary>
	public float AlphaThreshold;
}
