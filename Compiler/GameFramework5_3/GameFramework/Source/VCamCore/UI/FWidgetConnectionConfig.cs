namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/Switcher/WidgetConnectionConfig.h")]
public partial struct FWidgetConnectionConfig {
	public FVCamChildWidgetReference Widget;
	public TMap<FName,FVCamConnectionTargetSettings> ConnectionTargets;
}
