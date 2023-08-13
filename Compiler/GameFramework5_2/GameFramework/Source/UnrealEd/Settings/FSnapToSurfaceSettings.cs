namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings that control the behavior of the &quot;snap to surface&quot; feature</summary>
[CppInclude("Settings/LevelEditorViewportSettings.h")]
public partial struct FSnapToSurfaceSettings {
	public bool bEnabled;
	public float SnapOffsetExtent;
	public bool bSnapRotation;
}
