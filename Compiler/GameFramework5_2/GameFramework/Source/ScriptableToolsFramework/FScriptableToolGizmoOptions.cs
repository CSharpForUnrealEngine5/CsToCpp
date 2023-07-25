#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScriptableInteractiveTool.h")]
///<summary>FScriptableToolGizmoOptions is a configuration struct passed to the CreateTRSGizmo function</summary>
public partial struct FScriptableToolGizmoOptions {
// ScriptableToolGizmoOptions
	public EScriptableToolGizmoMode GizmoMode;
	public int TranslationParts;
	public int RotationParts;
	public int ScaleParts;
	public EScriptableToolGizmoCoordinateSystem CoordSystem;
	public bool bSnapTranslation;
	public bool bSnapRotation;
	public bool bRepositionable;
	public bool bAllowNegativeScaling;
}
