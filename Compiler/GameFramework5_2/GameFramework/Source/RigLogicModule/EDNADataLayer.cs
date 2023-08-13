namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DNACommon.h")]
public enum EDNADataLayer {
	None=0,
	Descriptor=1,
	Definition=-1,
	Behavior=-1,
	Geometry=-1,
	GeometryWithoutBlendShapes=-1,
	MachineLearnedBehavior=-1,
	All=-1,
}
