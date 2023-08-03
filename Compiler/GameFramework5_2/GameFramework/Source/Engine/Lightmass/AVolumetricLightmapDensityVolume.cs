#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides local control over volumetric lightmap density.  Only convex shapes supported.</summary>
[CppInclude("Lightmass/VolumetricLightmapDensityVolume.h")]
public partial class AVolumetricLightmapDensityVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>The Volumetric Lightmap has 3 mipmaps, where the highest density mipmap (mip0) corresponds to VolumetricLightmapDetailCellSize.</summary>
	public FInt32Interval AllowedMipLevelRange;
}
