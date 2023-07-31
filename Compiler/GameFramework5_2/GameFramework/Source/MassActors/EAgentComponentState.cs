#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassAgentComponent.h")]
public enum EAgentComponentState {
	None=0,
	EntityPendingCreation=1,
	EntityCreated=2,
	PuppetPendingInitialization=3,
	PuppetInitialized=4,
	PuppetPaused=5,
	PuppetPendingReplication=6,
	PuppetReplicatedOrphan=7,
}
