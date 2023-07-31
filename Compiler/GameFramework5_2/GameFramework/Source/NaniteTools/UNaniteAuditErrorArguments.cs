#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteToolsArguments.h")]
public partial class UNaniteAuditErrorArguments : UEditorConfigBase {
	///<summary>Prohibit non-opaque blend mode in the assigned materials.</summary>
	public bool ProhibitUnsupportedBlendMode;
	///<summary>Prohibit vertex interpolator usage in the assigned materials.</summary>
	public bool ProhibitVertexInterpolator;
	///<summary>Prohibit pixel depth offset usage in the assigned materials.</summary>
	public bool ProhibitPixelDepthOffset;
	///<summary>Prohibit world position offset usage in the assigned materials.</summary>
	public bool ProhibitWorldPositionOffset;
}
