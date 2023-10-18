namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/MovieGraphCommon.h")]
///<summary>The type of a graph member&#39;s value.</summary>
public enum EMovieGraphValueType {
	None=0,
	Bool=1,
	Byte=2,
	Int32=3,
	Int64=4,
	Float=5,
	Double=6,
	Name=7,
	String=8,
	Text=9,
	Enum=10,
	Struct=11,
	Object=12,
	SoftObject=13,
	Class=14,
	SoftClass=15,
	Count=16,
}
