#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FScriptableToolGizmoOptions is a configuration struct passed to the CreateTRSGizmo function</summary>
[CppInclude("ScriptableInteractiveTool.h")]
public partial struct FScriptableToolGizmoOptions {
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
