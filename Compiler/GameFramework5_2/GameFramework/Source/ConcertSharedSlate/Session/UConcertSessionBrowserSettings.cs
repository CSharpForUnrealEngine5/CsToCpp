#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Serializes the multi-user session browser settings like the active filters.</summary>
[CppInclude("Session/Browser/ConcertSessionBrowserSettings.h")]
public partial class UConcertSessionBrowserSettings : UObject {
	///<summary>LastModifiedTimeFormat</summary>
	public ETimeFormat LastModifiedTimeFormat;
	///<summary>bShowActiveSessions</summary>
	public bool bShowActiveSessions;
	///<summary>bShowArchivedSessions</summary>
	public bool bShowArchivedSessions;
	///<summary>bShowDefaultServerSessionsOnly</summary>
	public bool bShowDefaultServerSessionsOnly;
}
