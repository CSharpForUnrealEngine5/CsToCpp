namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyValue.h")]
public enum EPropertyValueCategory {
	Undefined=0,
	Generic=1,
	RelativeLocation=2,
	RelativeRotation=4,
	RelativeScale3D=8,
	Visibility=16,
	Material=32,
	Color=64,
	Option=128,
}
