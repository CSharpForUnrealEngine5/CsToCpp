#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Indicates what type of object the scene understanding system thinks it is</summary>
public enum EARObjectClassification {
	NotApplicable=0,
	Unknown=1,
	Wall=2,
	Ceiling=3,
	Floor=4,
	Table=5,
	Seat=6,
	Face=7,
	Image=8,
	World=9,
	SceneObject=10,
	HandMesh=11,
	Door=12,
	Window=13,
}
