#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/MultiUserServerColumnVisibilitySettings.h")]
public partial class UMultiUserServerColumnVisibilitySettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SessionBrowserColumnVisibility</summary>
	public FColumnVisibilitySnapshot SessionBrowserColumnVisibility;
	///<summary>DeleteActivityDialogColumnVisibility</summary>
	public FColumnVisibilitySnapshot DeleteActivityDialogColumnVisibility;
	///<summary>ArchivedActivityBrowserColumnVisibility</summary>
	public FColumnVisibilitySnapshot ArchivedActivityBrowserColumnVisibility;
	///<summary>LiveActivityBrowserColumnVisibility</summary>
	public FColumnVisibilitySnapshot LiveActivityBrowserColumnVisibility;
	///<summary>LiveSessionContentColumnVisibility</summary>
	public FColumnVisibilitySnapshot LiveSessionContentColumnVisibility;
	///<summary>TransportLogColumnVisibility</summary>
	public FColumnVisibilitySnapshot TransportLogColumnVisibility;
	///<summary>PackageTransmissionColumnVisibility</summary>
	public FColumnVisibilitySnapshot PackageTransmissionColumnVisibility;
}
