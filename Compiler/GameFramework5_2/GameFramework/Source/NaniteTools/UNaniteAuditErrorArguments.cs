namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteToolsArguments.h")]
public partial class UNaniteAuditErrorArguments : UEditorConfigBase {
	public static UClass StaticClass() {return default;}
	///<summary>Prohibit non-opaque blend mode in the assigned materials.</summary>
	public bool ProhibitUnsupportedBlendMode;
	///<summary>Prohibit vertex interpolator usage in the assigned materials.</summary>
	public bool ProhibitVertexInterpolator;
	///<summary>Prohibit pixel depth offset usage in the assigned materials.</summary>
	public bool ProhibitPixelDepthOffset;
	///<summary>Prohibit world position offset usage in the assigned materials.</summary>
	public bool ProhibitWorldPositionOffset;
}
