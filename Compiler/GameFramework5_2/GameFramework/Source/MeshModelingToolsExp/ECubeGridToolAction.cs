#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CubeGridTool.h")]
public enum ECubeGridToolAction {
	NoAction=0,
	Push=1,
	Pull=2,
	Flip=3,
	SlideForward=4,
	SlideBack=5,
	DecreaseGridPower=6,
	IncreaseGridPower=7,
	CornerMode=8,
	ResetFromActor=9,
	Done=10,
	Cancel=11,
}
