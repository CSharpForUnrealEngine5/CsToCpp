#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/PlacementSubsystem.h")]
public partial struct FAssetPlacementInfo {
	public FAssetData AssetToPlace;
	public string NameOverride;
	public TWeakObjectPtr<ULevel> PreferredLevel;
	public FTransform FinalizedTransform;
	public object /*FactoryOverride*/ FactoryOverride;
	public FGuid ItemGuid;
	public UInstancedPlacemenClientSettings SettingsObject;
}
