#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionEditorPerProjectUserSettings.h")]
public partial struct FWorldPartitionPerWorldSettings {
	public TArray<FBox> LoadedEditorRegions;
	public TArray<string> LoadedEditorLocationVolumes;
	public TArray<string> NotLoadedDataLayers;
	public TArray<string> LoadedDataLayers;
}
