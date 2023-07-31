#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Each Bone node in BoneTree</summary>
[CppInclude("Animation/Skeleton.h")]
public partial struct FBoneNode {
	public string Name_DEPRECATED;
	public int ParentIndex_DEPRECATED;
	public EBoneTranslationRetargetingMode TranslationRetargetingMode;
}
