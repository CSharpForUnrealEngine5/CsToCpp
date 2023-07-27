#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetPlacementSettings.h")]
public partial class UAssetPlacementSettings : UObject {
// AssetPlacementSettings
	public bool bAlignToNormal;
	public EAxis AxisToAlignWithNormal;
	public bool bInvertNormalAxis;
	public bool bUseRandomRotationX;
	public FFloatInterval RandomRotationX;
	public bool bAllowNegativeRotationX;
	public bool bUseRandomRotationY;
	public FFloatInterval RandomRotationY;
	public bool bAllowNegativeRotationY;
	public bool bUseRandomRotationZ;
	public FFloatInterval RandomRotationZ;
	public bool bAllowNegativeRotationZ;
	public EFoliageScaling ScalingType;
	public FFloatInterval ScaleRange;
	public bool bUseRandomScale;
	public bool bAllowNegativeScale;
	public FVector RelativeLocationOffset;
	public bool bScaleRelativeLocationOffset;
	public FVector WorldLocationOffset;
	public bool bScaleWorldLocationOffset;
	public bool bLandscape;
	public bool bStaticMeshes;
	public bool bBSP;
	public bool bFoliage;
	public bool bTranslucent;
	public bool bUseContentBrowserSelection;
	public UPlacementPaletteAsset ActivePalette;
	public UPlacementPaletteAsset UserPalette;
	public FGuid UserGridGuid;
	public FSoftObjectPath LastActivePalettePath;
}
