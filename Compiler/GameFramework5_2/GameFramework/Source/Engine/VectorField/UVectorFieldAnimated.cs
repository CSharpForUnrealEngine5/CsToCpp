#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VectorField/VectorFieldAnimated.h")]
public partial class UVectorFieldAnimated : UVectorField {
// VectorFieldAnimated
	public UTexture2D Texture;
	public byte ConstructionOp;
	public int VolumeSizeX;
	public int VolumeSizeY;
	public int VolumeSizeZ;
	public int SubImagesX;
	public int SubImagesY;
	public int FrameCount;
	public float FramesPerSecond;
	public bool bLoop;
	public UVectorFieldStatic NoiseField;
	public float NoiseScale;
	public float NoiseMax;
}
