namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UProjectionProperties</summary>
[CppInclude("SkeletalMesh/SkeletonEditingTool.h")]
public partial class UProjectionProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>ProjectionType</summary>
	public EProjectionType ProjectionType;
	///<summary>PlaneOrigin</summary>
	public FVector PlaneOrigin;
	///<summary>PlaneNormal</summary>
	public FVector PlaneNormal;
}
