namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigEditor/IKRigEditorController.h")]
public partial class UIKRigBoneDetails : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedBone</summary>
	public string SelectedBone;
	///<summary>CurrentTransform</summary>
	public FTransform CurrentTransform;
	///<summary>ReferenceTransform</summary>
	public FTransform ReferenceTransform;
	///<summary>AnimInstancePtr</summary>
	public TWeakObjectPtr<UAnimInstance> AnimInstancePtr;
	///<summary>AssetPtr</summary>
	public TWeakObjectPtr<UIKRigDefinition> AssetPtr;
}
