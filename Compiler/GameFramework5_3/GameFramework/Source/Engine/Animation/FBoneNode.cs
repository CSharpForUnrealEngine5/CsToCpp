namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Each Bone node in BoneTree</summary>
[CppInclude("Animation/Skeleton.h")]
public partial struct FBoneNode {
	public FName Name_DEPRECATED;
	public int ParentIndex_DEPRECATED;
	public EBoneTranslationRetargetingMode TranslationRetargetingMode;
}
