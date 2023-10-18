namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargetDetails.h")]
public partial class UIKRetargetBoneDetails : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedBone</summary>
	public FName SelectedBone;
	///<summary>LocalTransform</summary>
	public FTransform LocalTransform;
	///<summary>OffsetTransform</summary>
	public FTransform OffsetTransform;
	///<summary>CurrentTransform</summary>
	public FTransform CurrentTransform;
	///<summary>ReferenceTransform</summary>
	public FTransform ReferenceTransform;
}
