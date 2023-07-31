#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NaniteToolsArguments.h")]
public partial class UNaniteAuditOptimizeArguments : UEditorConfigBase {
	///<summary>Ignore non-Nanite meshes with fewer triangles than this threshold.</summary>
	public uint TriangleThreshold;
	///<summary>Ignore non-Nanite meshes using an unsupported blend mode in the assigned materials.</summary>
	public bool DisallowUnsupportedBlendMode;
	///<summary>Ignore non-Nanite meshes using vertex interpolator in the assigned materials.</summary>
	public bool DisallowVertexInterpolator;
	///<summary>Ignore non-Nanite meshes using pixel depth offset in the assigned materials.</summary>
	public bool DisallowPixelDepthOffset;
	///<summary>Ignore non-Nanite meshes using world position offset in the assigned materials.</summary>
	public bool DisallowWorldPositionOffset;
}
