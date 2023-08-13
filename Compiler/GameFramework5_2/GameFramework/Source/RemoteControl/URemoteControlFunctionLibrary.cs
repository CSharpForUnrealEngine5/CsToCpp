namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlFunctionLibrary.h")]
public partial class URemoteControlFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Expose a property in a remote control preset.</summary>
	public static bool ExposeProperty(URemoteControlPreset Preset,UObject SourceObject,string Property,FRemoteControlOptionalExposeArgs Args) { return default; }
	///<summary>Expose a function in a remote control preset.</summary>
	public static bool ExposeFunction(URemoteControlPreset Preset,UObject SourceObject,string Function,FRemoteControlOptionalExposeArgs Args) { return default; }
	///<summary>Expose an actor in a remote control preset.</summary>
	public static bool ExposeActor(URemoteControlPreset Preset,AActor Actor,FRemoteControlOptionalExposeArgs Args) { return default; }
	///<summary>Add/subtract from the value of an FLinearColor property using a delta value based on color wheel coordinates.</summary>
	public static bool ApplyColorWheelDelta(UObject TargetObject,string PropertyName,FColorWheelColor DeltaValue,FColorWheelColor ReferenceColor,bool bIsInteractive) { return default; }
	///<summary>Add/subtract from the value of an FVector4 property interpreted as RGBV using a delta value based on color wheel coordinates.</summary>
	public static bool ApplyColorGradingWheelDelta(UObject TargetObject,string PropertyName,FColorGradingWheelColor DeltaValue,FColorGradingWheelColor ReferenceColor,bool bIsInteractive,float MinValue/*=0.0f*/,float MaxValue/*=2.0f*/) { return default; }
}
