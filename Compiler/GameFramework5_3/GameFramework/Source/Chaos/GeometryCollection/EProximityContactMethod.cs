namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionProximityUtility.h")]
public enum EProximityContactMethod {
	MinOverlapInProjectionToMajorAxes=0,
	ConvexHullSharpContact=1,
	ConvexHullAreaContact=2,
}
