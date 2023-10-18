namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Enum for specifying the source of a bone&#39;s rotation.</summary>
public enum EBoneRotationSource {
	BRS_KeepComponentSpaceRotation=0,
	BRS_KeepLocalSpaceRotation=1,
	BRS_CopyFromTarget=2,
}
