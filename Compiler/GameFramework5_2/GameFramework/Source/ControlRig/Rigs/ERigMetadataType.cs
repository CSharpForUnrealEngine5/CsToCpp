#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyDefines.h")]
///<summary>* The type of meta data stored on an element</summary>
public enum ERigMetadataType {
	Bool=0,
	BoolArray=1,
	Float=2,
	FloatArray=3,
	Int32=4,
	Int32Array=5,
	Name=6,
	NameArray=7,
	Vector=8,
	VectorArray=9,
	Rotator=10,
	RotatorArray=11,
	Quat=12,
	QuatArray=13,
	Transform=14,
	TransformArray=15,
	LinearColor=16,
	LinearColorArray=17,
	RigElementKey=18,
	RigElementKeyArray=19,
	Invalid=20,
}
