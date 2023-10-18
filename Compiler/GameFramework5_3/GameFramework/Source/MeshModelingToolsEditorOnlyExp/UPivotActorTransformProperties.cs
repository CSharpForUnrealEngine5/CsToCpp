namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPivotActorTool.h")]
public partial class UPivotActorTransformProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Position</summary>
	public FVector Position;
	///<summary>Rotation</summary>
	public FQuat Rotation;
}
