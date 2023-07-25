#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Announcement/ScreenReaderAnnouncement.h")]
///<summary>A struct that contains information about how a screen reader announcement should behave when the announcement is requested to be spoken.</summary>
public partial struct FScreenReaderAnnouncementInfo {
// ScreenReaderAnnouncementInfo
	public bool bShouldQueue;
	public bool bInterruptable;
	public EScreenReaderAnnouncementPriority Priority;
}
