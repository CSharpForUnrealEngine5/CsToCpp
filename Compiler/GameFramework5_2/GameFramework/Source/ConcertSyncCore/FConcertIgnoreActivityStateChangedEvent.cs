#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sets the specified client &#39;ignore on restore&#39; state for further activities. The &#39;ignored&#39; flag can be raised to mark a series of activities as &#39;should not be restored&#39;.</summary>
[CppInclude("ConcertWorkspaceMessages.h")]
public partial struct FConcertIgnoreActivityStateChangedEvent {
	public FGuid EndpointId;
	public bool bIgnore;
}
