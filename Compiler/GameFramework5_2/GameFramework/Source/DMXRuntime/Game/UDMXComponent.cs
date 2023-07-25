#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Game/DMXComponent.h")]
///<summary>Component that receives DMX input each Tick from a fixture patch.</summary>
public partial class UDMXComponent : UActorComponent {
// DMXComponent
	public void FDMXComponentFixturePatchReceivedSignature(UObject FixturePatch,FDMXNormalizedAttributeValueMap ValuePerAttribute) {}
	public void FDMXOnDMXComponentTickSignature(float DeltaTime) {}
	public FDMXComponentFixturePatchReceivedSignature OnFixturePatchReceived;
	public FDMXOnDMXComponentTickSignature OnDMXComponentTick;
	public UObject GetFixturePatch() { return default; }
	public void SetFixturePatch(UObject InFixturePatch) {}
	public void SetReceiveDMXFromPatch(bool bReceive) {}
	public FDMXEntityFixturePatchRef FixturePatchRef;
	public void OnFixturePatchReceivedDMX(UObject FixturePatch,FDMXNormalizedAttributeValueMap NormalizedValuePerAttribute) {}
	public bool bReceiveDMXFromPatch;
}
