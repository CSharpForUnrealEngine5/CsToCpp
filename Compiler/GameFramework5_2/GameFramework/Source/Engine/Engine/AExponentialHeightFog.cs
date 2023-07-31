#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an Actor for exponential height fog.</summary>
[CppInclude("Engine/ExponentialHeightFog.h")]
public partial class AExponentialHeightFog : AInfo {
	///<summary>@todo document</summary>
	public UExponentialHeightFogComponent Component;
	///<summary>replicated copy of ExponentialHeightFogComponent&#39;s bEnabled property</summary>
	public bool bEnabled;
	///<summary>Replication Notification Callbacks</summary>
	public  void OnRep_bEnabled() {}
}
