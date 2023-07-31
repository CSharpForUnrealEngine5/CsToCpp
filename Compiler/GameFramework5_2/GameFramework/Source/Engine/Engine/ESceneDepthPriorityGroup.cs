#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>A priority for sorting scene elements by depth.</summary>
public enum ESceneDepthPriorityGroup {
	SDPG_World=0,
	SDPG_Foreground=1,
	SDPG_MAX=2,
}
