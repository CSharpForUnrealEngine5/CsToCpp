namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>USkeletonEditingProperties</summary>
[CppInclude("SkeletalMesh/SkeletonEditingTool.h")]
public partial class USkeletonEditingProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Name</summary>
	public FName Name;
	///<summary>Transform</summary>
	public FTransform Transform;
	///<summary>bUpdateChildren</summary>
	public bool bUpdateChildren;
	///<summary>AxisLength</summary>
	public float AxisLength;
	///<summary>AxisThickness</summary>
	public float AxisThickness;
}
