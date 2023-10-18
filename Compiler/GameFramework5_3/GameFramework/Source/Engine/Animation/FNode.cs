namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rig Controller for bone transform *</summary>
[CppInclude("Animation/Rig.h")]
public partial struct FNode {
	public FName Name;
	public FName ParentName;
	public FTransform Transform;
	public string DisplayName;
	public bool bAdvanced;
}
