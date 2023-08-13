namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AzureCloudSpatialAnchor.h")]
public partial class UAzureCloudSpatialAnchor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The ARPin with which this cloud anchor is associated, or null.  Null could mean we are still trying to load the anchor or have not yet located it.</summary>
	public UARPin ARPin;
	///<summary>The Azure Cloud identifier of the spatial anchor is the persistent identifier by which a cloud anchor can be requested from the azure cloud service.  Empty if the anchor has not been saved or loaded yet.</summary>
	public string GetAzureCloudIdentifier() { return default; }
	///<summary>The AppProperties dictionary of the cloud anchor.</summary>
	public TMap<string,string> GetAppProperties() { return default; }
	///<summary>Set the AppProperties dictionary of the cloud anchor.  You must call SaveCloudAnchor or UpdateCloudAnchorProperties before these will be persisted on azure.</summary>
	public void SetAppProperties(TMap<string,string> InAppProperties) {}
	///<summary>The Expiration time of the cloud anchor as seconds into the future.</summary>
	public float GetExpiration() { return default; }
	///<summary>Set the Expiration time of the cloud anchor as seconds into the future.  You must call SaveCloudAnchor or UpdateCloudAnchorProperties before this will be persisted on azure.</summary>
	public void SetExpiration(float Lifetime) {}
}
