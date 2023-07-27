#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureCloudSpatialAnchor.h")]
public partial class UAzureCloudSpatialAnchor : UObject {
// AzureCloudSpatialAnchor
	public UARPin ARPin;
	public  string GetAzureCloudIdentifier() { return default; }
	public  TMap<string,string> GetAppProperties() { return default; }
	public  void SetAppProperties(TMap<string,string> InAppProperties) {}
	public  float GetExpiration() { return default; }
	public  void SetExpiration(float Lifetime) {}
}
