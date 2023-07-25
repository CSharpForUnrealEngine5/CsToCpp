#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureSpatialAnchorsTypes.h")]
public partial struct FAzureSpatialAnchorsLocateCriteria {
// AzureSpatialAnchorsLocateCriteria
	public bool bBypassCache;
	public TArray<string> Identifiers;
	public UAzureCloudSpatialAnchor NearAnchor;
	public float NearAnchorDistance;
	public int NearAnchorMaxResultCount;
	public bool bSearchNearDevice;
	public float NearDeviceDistance;
	public int NearDeviceMaxResultCount;
	public EAzureSpatialAnchorDataCategory RequestedCategories;
	public EAzureSpatialAnchorsLocateStrategy Strategy;
}
