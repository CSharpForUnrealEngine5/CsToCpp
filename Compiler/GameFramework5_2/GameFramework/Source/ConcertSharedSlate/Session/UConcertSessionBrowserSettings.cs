#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Session/Browser/ConcertSessionBrowserSettings.h")]
///<summary>Serializes the multi-user session browser settings like the active filters.</summary>
public partial class UConcertSessionBrowserSettings : UObject {
// ConcertSessionBrowserSettings
	public ETimeFormat LastModifiedTimeFormat;
	public bool bShowActiveSessions;
	public bool bShowArchivedSessions;
	public bool bShowDefaultServerSessionsOnly;
}
