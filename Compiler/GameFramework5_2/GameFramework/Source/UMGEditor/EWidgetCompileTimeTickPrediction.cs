#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetBlueprint.h")]
///<summary>This represents the tickability of a widget computed at compile time</summary>
public enum EWidgetCompileTimeTickPrediction {
	WontTick=0,
	OnDemand=1,
	WillTick=2,
}
