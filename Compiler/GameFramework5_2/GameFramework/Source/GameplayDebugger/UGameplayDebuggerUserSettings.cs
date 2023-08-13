namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial class UGameplayDebuggerUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Controls whether GameplayDebugger will be available in pure editor mode.</summary>
	public bool bEnableGameplayDebuggerInEditor;
	///<summary>Distance from view location under which actors can be selected</summary>
	public float MaxViewDistance;
	///<summary>Angle from view direction under which actors can be selected</summary>
	public float MaxViewAngle;
	///<summary>Font Size used by Gameplay Debugger</summary>
	public int FontSize;
}
