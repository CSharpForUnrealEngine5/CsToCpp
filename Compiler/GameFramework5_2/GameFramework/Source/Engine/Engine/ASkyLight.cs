#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkyLight.h")]
public partial class ASkyLight : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>@todo document</summary>
	public USkyLightComponent LightComponent;
	///<summary>replicated copy of LightComponent&#39;s bEnabled property</summary>
	public bool bEnabled;
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_bEnabled() {}
}
