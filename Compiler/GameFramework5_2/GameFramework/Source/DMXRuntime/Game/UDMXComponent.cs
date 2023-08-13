namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that receives DMX input each Tick from a fixture patch.</summary>
[CppInclude("Game/DMXComponent.h")]
public partial class UDMXComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FDMXComponentFixturePatchReceivedSignature</summary>
	public void FDMXComponentFixturePatchReceivedSignature(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	///<summary>FDMXOnDMXComponentTickSignature</summary>
	public void FDMXOnDMXComponentTickSignature(float DeltaTime) {}
	///<summary>Broadcast when the component&#39;s fixture patch received DMX</summary>
	public FDMXComponentFixturePatchReceivedSignature OnFixturePatchReceived;
	///<summary>Event raised each tick, when the component has a Fixture Patch set and either:</summary>
	public FDMXOnDMXComponentTickSignature OnDMXComponentTick;
	///<summary>Gets the fixture patch used in the component</summary>
	public UDMXEntityFixturePatch GetFixturePatch() { return default; }
	///<summary>Sets the fixture patch used in the component</summary>
	public void SetFixturePatch(UDMXEntityFixturePatch InFixturePatch) {}
	///<summary>Sets whether the component receives dmx from the patch. Note, this is saved with the component when called in editor.</summary>
	public void SetReceiveDMXFromPatch(bool bReceive) {}
	///<summary>FixturePatchRef</summary>
	public FDMXEntityFixturePatchRef FixturePatchRef;
	///<summary>Called when the fixture patch received DMX</summary>
	public void OnFixturePatchReceivedDMX(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap NormalizedValuePerAttribute) {}
	///<summary>If true, the component will receive DMX from the patch</summary>
	public bool bReceiveDMXFromPatch;
}
