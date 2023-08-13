namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IO/DMXInputPortConfig.h")]
///<summary>Strategy for priority system (when receiving packets)</summary>
public enum EDMXPortPriorityStrategy {
	None=0,
	Equal=1,
	HigherThan=2,
	LowerThan=3,
	Highest=4,
	Lowest=5,
}
