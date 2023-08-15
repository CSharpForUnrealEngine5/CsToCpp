namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/PlacementSubsystem.h")]
public partial struct FAssetPlacementInfo {
	public FAssetData AssetToPlace;
	public FName NameOverride;
	public TWeakObjectPtr<ULevel> PreferredLevel;
	public FTransform FinalizedTransform;
	public object /*FactoryOverride*/ FactoryOverride;
	public FGuid ItemGuid;
	public UInstancedPlacemenClientSettings SettingsObject;
}
