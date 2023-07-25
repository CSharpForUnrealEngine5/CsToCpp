#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneComponent.h")]
///<summary>The space for the transform</summary>
public enum ERelativeTransformSpace {
	RTS_World=0,
	RTS_Actor=1,
	RTS_Component=2,
	RTS_ParentBoneSpace=3,
}
