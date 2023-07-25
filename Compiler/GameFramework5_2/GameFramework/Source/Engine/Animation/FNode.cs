#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/Rig.h")]
///<summary>Rig Controller for bone transform *</summary>
public partial struct FNode {
// Node
	public string Name;
	public string ParentName;
	public FTransform Transform;
	public string DisplayName;
	public bool bAdvanced;
}
