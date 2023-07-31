#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/Switcher/WidgetConnectionConfig.h")]
public partial struct FWidgetConnectionConfig {
	public FVCamChildWidgetReference Widget;
	public TMap<string,FVCamConnectionTargetSettings> ConnectionTargets;
}
