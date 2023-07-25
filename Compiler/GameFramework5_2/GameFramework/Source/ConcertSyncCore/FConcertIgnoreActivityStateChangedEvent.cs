#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertWorkspaceMessages.h")]
///<summary>Sets the specified client 'ignore on restore' state for further activities. The 'ignored' flag can be raised to mark a series of activities as 'should not be restored'.</summary>
public partial struct FConcertIgnoreActivityStateChangedEvent {
// ConcertIgnoreActivityStateChangedEvent
	public FGuid EndpointId;
	public bool bIgnore;
}
