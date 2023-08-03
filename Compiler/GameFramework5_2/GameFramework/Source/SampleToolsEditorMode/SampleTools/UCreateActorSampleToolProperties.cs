#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings UObject for UCreateActorSampleTool. This UClass inherits from UInteractiveToolPropertySet,</summary>
[CppInclude("SampleTools/CreateActorSampleTool.h")]
public partial class UCreateActorSampleToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Place actors on existing objects</summary>
	public bool PlaceOnObjects;
	///<summary>Height of ground plane</summary>
	public float GroundHeight;
}
