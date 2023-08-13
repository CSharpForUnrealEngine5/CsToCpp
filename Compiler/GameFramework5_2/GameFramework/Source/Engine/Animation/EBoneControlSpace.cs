namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Enum for controlling which reference frame a controller is applied in.</summary>
public enum EBoneControlSpace {
	BCS_WorldSpace=0,
	BCS_ComponentSpace=1,
	BCS_ParentBoneSpace=2,
	BCS_BoneSpace=3,
	BCS_MAX=4,
}
