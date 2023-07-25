#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/PlacementSubsystem.h")]
public partial struct FAssetPlacementInfo {
// AssetPlacementInfo
	public FAssetData AssetToPlace;
	public string NameOverride;
	public TWeakObjectPtr<ULevel> PreferredLevel;
	public FTransform FinalizedTransform;
	public object /*FactoryOverride*/ FactoryOverride;
	public FGuid ItemGuid;
	public UInstancedPlacemenClientSettings SettingsObject;
}
