#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/SubUVAnimation.h")]
///<summary>SubUV animation asset, which caches bounding geometry for regions in the SubUVTexture with non-zero opacity.</summary>
public partial class USubUVAnimation : UObject {
// SubUVAnimation
	public UTexture2D SubUVTexture;
	public int SubImages_Horizontal;
	public int SubImages_Vertical;
	public byte BoundingMode;
	public byte OpacitySourceMode;
	public float AlphaThreshold;
}
