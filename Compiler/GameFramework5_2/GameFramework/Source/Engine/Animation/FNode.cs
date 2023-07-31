#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rig Controller for bone transform *</summary>
[CppInclude("Animation/Rig.h")]
public partial struct FNode {
	public string Name;
	public string ParentName;
	public FTransform Transform;
	public string DisplayName;
	public bool bAdvanced;
}
