#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputCoreTypes.h")]
///<summary>Various states of touch inputs.</summary>
public enum ETouchType {
	Began=0,
	Moved=1,
	Stationary=2,
	ForceChanged=3,
	FirstMove=4,
	Ended=5,
	NumTypes=6,
}
