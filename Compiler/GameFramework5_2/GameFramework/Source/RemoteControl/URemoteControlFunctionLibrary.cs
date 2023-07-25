#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlFunctionLibrary.h")]
public partial class URemoteControlFunctionLibrary : UBlueprintFunctionLibrary {
// RemoteControlFunctionLibrary
	public bool ExposeProperty(UObject Preset,UObject SourceObject,string Property,FRemoteControlOptionalExposeArgs Args) { return default; }
	public bool ExposeFunction(UObject Preset,UObject SourceObject,string Function,FRemoteControlOptionalExposeArgs Args) { return default; }
	public bool ExposeActor(UObject Preset,UObject Actor,FRemoteControlOptionalExposeArgs Args) { return default; }
	public bool ApplyColorWheelDelta(UObject TargetObject,string PropertyName,FColorWheelColor DeltaValue,FColorWheelColor ReferenceColor,bool bIsInteractive) { return default; }
	public bool ApplyColorGradingWheelDelta(UObject TargetObject,string PropertyName,FColorGradingWheelColor DeltaValue,FColorGradingWheelColor ReferenceColor,bool bIsInteractive,float MinValue/*=0.0f*/,float MaxValue/*=2.0f*/) { return default; }
}
