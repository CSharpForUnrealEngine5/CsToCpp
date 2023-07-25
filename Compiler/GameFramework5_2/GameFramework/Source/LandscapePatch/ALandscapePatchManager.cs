#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapePatchManager.h")]
///<summary>Acts as the "blueprint brush" as far as the owning edit layer is concerned. In reality, has its contained</summary>
public partial class ALandscapePatchManager : ALandscapeBlueprintBrushBase {
// LandscapePatchManager
	public TArray<TSoftObjectPtr<ULandscapePatchComponent>> PatchComponents;
	public FTransform HeightmapCoordsToWorld;
	public ALandscape DetailPanelLandscape;
}
