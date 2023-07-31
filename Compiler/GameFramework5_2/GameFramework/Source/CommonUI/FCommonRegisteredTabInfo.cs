#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a registered tab in the tab list</summary>
[CppInclude("CommonTabListWidgetBase.h")]
public partial struct FCommonRegisteredTabInfo {
	public int TabIndex;
	public UCommonButtonBase TabButton;
	public UWidget ContentInstance;
}
