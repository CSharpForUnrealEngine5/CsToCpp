#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusHMDTypes.h")]
public partial struct FOculusSplashDesc {
	public FSoftObjectPath TexturePath;
	public FTransform TransformInMeters;
	public FVector2D QuadSizeInMeters;
	public FQuat DeltaRotation;
	public FVector2D TextureOffset;
	public FVector2D TextureScale;
	public bool bNoAlphaChannel;
}
