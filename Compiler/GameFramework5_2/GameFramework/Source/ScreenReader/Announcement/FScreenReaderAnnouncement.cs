#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A screen reader announcement represents a localized message that a user wants to speak to an end user.</summary>
[CppInclude("Announcement/ScreenReaderAnnouncement.h")]
public partial struct FScreenReaderAnnouncement {
	public string AnnouncementString;
	public FScreenReaderAnnouncementInfo AnnouncementInfo;
}
