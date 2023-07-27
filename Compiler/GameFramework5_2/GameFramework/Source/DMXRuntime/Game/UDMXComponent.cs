#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Game/DMXComponent.h")]
///<summary>Component that receives DMX input each Tick from a fixture patch.</summary>
public partial class UDMXComponent : UActorComponent {
// DMXComponent
	public  void FDMXComponentFixturePatchReceivedSignature(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	public  void FDMXOnDMXComponentTickSignature(float DeltaTime) {}
	public FDMXComponentFixturePatchReceivedSignature OnFixturePatchReceived;
	public FDMXOnDMXComponentTickSignature OnDMXComponentTick;
	public  UDMXEntityFixturePatch GetFixturePatch() { return default; }
	public  void SetFixturePatch(UDMXEntityFixturePatch InFixturePatch) {}
	public  void SetReceiveDMXFromPatch(bool bReceive) {}
	public FDMXEntityFixturePatchRef FixturePatchRef;
	public  void OnFixturePatchReceivedDMX(UDMXEntityFixturePatch FixturePatch,FDMXNormalizedAttributeValueMap NormalizedValuePerAttribute) {}
	public bool bReceiveDMXFromPatch;
}
