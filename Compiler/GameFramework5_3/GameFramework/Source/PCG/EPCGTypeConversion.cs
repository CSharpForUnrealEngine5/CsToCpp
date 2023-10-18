namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public enum EPCGTypeConversion {
	NoConversionRequired=0,
	CollapseToPoint=1,
	Filter=2,
	MakeConcrete=3,
	Failed=4,
}
