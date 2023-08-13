namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/EditorPerformanceSettings.h")]
///<summary>Mode for the computation of the screen percentage (r.ScreenPercentage.Mode).</summary>
public enum EEditorUserScreenPercentageModeOverride {
	ProjectDefault=0,
	Manual=1,
	BasedOnDisplayResolution=2,
	BasedOnDPIScale=3,
}
