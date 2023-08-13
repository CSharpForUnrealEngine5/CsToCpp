namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct that contains information about how a screen reader announcement should behave when the announcement is requested to be spoken.</summary>
[CppInclude("Announcement/ScreenReaderAnnouncement.h")]
public partial struct FScreenReaderAnnouncementInfo {
	public bool bShouldQueue;
	public bool bInterruptable;
	public EScreenReaderAnnouncementPriority Priority;
}
