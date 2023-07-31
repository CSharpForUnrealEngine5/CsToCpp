#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetPlacementSettings.h")]
public partial class UAssetPlacementSettings : UObject {
	///<summary>Set to true if the tool should automatically align placement to an axis.</summary>
	public bool bAlignToNormal;
	///<summary>The axis which the tool should use for alignment calculations. This axis is positive unless Invert Normal Axis is set.</summary>
	public EAxis AxisToAlignWithNormal;
	///<summary>Set to true if the tool should negate the alignment axis.</summary>
	public bool bInvertNormalAxis;
	///<summary>Set to true if the tool should generate a random rotation on the X axis</summary>
	public bool bUseRandomRotationX;
	///<summary>The range in degrees at which the tool should generate a random rotation on the X axis.</summary>
	public FFloatInterval RandomRotationX;
	///<summary>Set to true if the tool should generate a negatively signed rotation on the X axis.</summary>
	public bool bAllowNegativeRotationX;
	///<summary>Set to true if the tool should generate a random rotation on the Y axis</summary>
	public bool bUseRandomRotationY;
	///<summary>The range in degrees at which the tool should generate a random rotation on the Y axis.</summary>
	public FFloatInterval RandomRotationY;
	///<summary>Set to true if the tool should generate a negatively signed rotation on the Y axis.</summary>
	public bool bAllowNegativeRotationY;
	///<summary>Set to true if the tool should generate a random rotation on the Z axis</summary>
	public bool bUseRandomRotationZ;
	///<summary>The range in degrees at which the tool should generate a random rotation on the Z axis.</summary>
	public FFloatInterval RandomRotationZ;
	///<summary>Set to true if the tool should generate a negatively signed rotation on the Z axis.</summary>
	public bool bAllowNegativeRotationZ;
	///<summary>Which axes scale should be applied to. Any locked axes will be scaled to 1.0f.</summary>
	public EFoliageScaling ScalingType;
	///<summary>The min and max at which a random scale is generated, or a scale is applied.</summary>
	public FFloatInterval ScaleRange;
	///<summary>Set to true if the tool should randomly scale any generated assets</summary>
	public bool bUseRandomScale;
	///<summary>Set to true if the tool should generate a negatively signed scale.</summary>
	public bool bAllowNegativeScale;
	///<summary>The spawn location offset in relative space.</summary>
	public FVector RelativeLocationOffset;
	///<summary>If the relative location offset should match scale with the placed asset.</summary>
	public bool bScaleRelativeLocationOffset;
	///<summary>The spawn rotation offset in world space.</summary>
	public FVector WorldLocationOffset;
	///<summary>If the world location offset should match scale with the placed asset.</summary>
	public bool bScaleWorldLocationOffset;
	///<summary>If the tool should place on landscape surfaces.</summary>
	public bool bLandscape;
	///<summary>If the tool should place on static mesh surfaces.</summary>
	public bool bStaticMeshes;
	///<summary>If the tool should place on BSP surfaces.</summary>
	public bool bBSP;
	///<summary>If the tool should place on foliage surfaces.</summary>
	public bool bFoliage;
	///<summary>If the tool should place on translucent surfaces.</summary>
	public bool bTranslucent;
	///<summary>bUseContentBrowserSelection</summary>
	public bool bUseContentBrowserSelection;
	///<summary>ActivePalette</summary>
	public UPlacementPaletteAsset ActivePalette;
	///<summary>UserPalette</summary>
	public UPlacementPaletteAsset UserPalette;
	///<summary>UserGridGuid</summary>
	public FGuid UserGridGuid;
	///<summary>LastActivePalettePath</summary>
	public FSoftObjectPath LastActivePalettePath;
}
