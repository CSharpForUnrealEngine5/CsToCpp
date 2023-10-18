namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>The different methods that can be used to determine what happens to text when it is longer than its allowed length</summary>
public enum ETextOverflowPolicy {
	Clip=0,
	Ellipsis=1,
}
