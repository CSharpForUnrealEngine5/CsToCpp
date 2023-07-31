#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info used to populate a create widget tool stack</summary>
[CppInclude("Settings/CreateWidgetToolSettings.h")]
public partial struct FCreateWidgetStackInfo {
	public string DisplayName;
	public TArray<FCreateWidgetToolInfo> WidgetToolInfos;
}
