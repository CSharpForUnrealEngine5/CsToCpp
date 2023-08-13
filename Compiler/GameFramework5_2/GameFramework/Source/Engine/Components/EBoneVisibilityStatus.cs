namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkinnedMeshComponent.h")]
///<summary>The valid BoneVisibilityStates values; A bone is only visible if it is *exactly* 1</summary>
public enum EBoneVisibilityStatus {
	BVS_HiddenByParent=0,
	BVS_Visible=1,
	BVS_ExplicitlyHidden=2,
	BVS_MAX=3,
}
