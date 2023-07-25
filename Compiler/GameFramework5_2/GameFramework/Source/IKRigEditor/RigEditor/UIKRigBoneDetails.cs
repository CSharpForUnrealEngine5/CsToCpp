#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigEditor/IKRigEditorController.h")]
public partial class UIKRigBoneDetails : UObject {
// IKRigBoneDetails
	public string SelectedBone;
	public FTransform CurrentTransform;
	public FTransform ReferenceTransform;
	public TWeakObjectPtr<UAnimInstance> AnimInstancePtr;
	public TWeakObjectPtr<UIKRigDefinition> AssetPtr;
}
