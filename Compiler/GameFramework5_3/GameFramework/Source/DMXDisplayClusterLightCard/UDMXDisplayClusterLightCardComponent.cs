namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXDisplayClusterLightCardComponent.h")]
public partial class UDMXDisplayClusterLightCardComponent : UDMXComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Value ranges for Min and Max DMX Values</summary>
	public FDMXDisplayClusterLightCardActorDataValueRanges ValueRanges;
	///<summary>Called when the fixture patch received DMX</summary>
	public void OnLightCardReceivedDMXFromPatch(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
}
