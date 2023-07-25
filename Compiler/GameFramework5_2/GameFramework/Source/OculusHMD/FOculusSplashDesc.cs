#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusHMDTypes.h")]
public partial struct FOculusSplashDesc {
// OculusSplashDesc
	public FSoftObjectPath TexturePath;
	public FTransform TransformInMeters;
	public FVector2D QuadSizeInMeters;
	public FQuat DeltaRotation;
	public FVector2D TextureOffset;
	public FVector2D TextureScale;
	public bool bNoAlphaChannel;
}
