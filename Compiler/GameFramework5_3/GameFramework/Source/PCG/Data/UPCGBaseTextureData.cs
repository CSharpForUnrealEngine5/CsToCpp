namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGTextureData.h")]
public partial class UPCGBaseTextureData : UPCGSurfaceData {
	public static UClass StaticClass() {return default;}
	///<summary>DensityFunction</summary>
	public EPCGTextureDensityFunction DensityFunction;
	///<summary>ColorChannel</summary>
	public EPCGTextureColorChannel ColorChannel;
	///<summary>The size of one texel in cm, used when calling ToPointData.</summary>
	public float TexelSize;
	///<summary>Whether to tile the source or to stretch it to fit target area.</summary>
	public bool bUseAdvancedTiling;
	///<summary>Tiling</summary>
	public FVector2D Tiling;
	///<summary>CenterOffset</summary>
	public FVector2D CenterOffset;
	///<summary>Rotation to apply when sampling texture.</summary>
	public float Rotation;
	///<summary>bUseTileBounds</summary>
	public bool bUseTileBounds;
	///<summary>TileBounds</summary>
	public FBox2D TileBounds;
	///<summary>ColorData</summary>
	public TArray<FLinearColor> ColorData;
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>Height</summary>
	public int Height;
	///<summary>Width</summary>
	public int Width;
}
