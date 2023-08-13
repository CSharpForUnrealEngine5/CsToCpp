namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Acts as the &quot;blueprint brush&quot; as far as the owning edit layer is concerned. In reality, has its contained</summary>
[CppInclude("LandscapePatchManager.h")]
public partial class ALandscapePatchManager : ALandscapeBlueprintBrushBase {
	public static UClass StaticClass() {return default;}
	///<summary>PatchComponents</summary>
	public TArray<TSoftObjectPtr<ULandscapePatchComponent>> PatchComponents;
	///<summary>HeightmapCoordsToWorld</summary>
	public FTransform HeightmapCoordsToWorld;
	///<summary>The owning landscape.</summary>
	public ALandscape DetailPanelLandscape;
}
