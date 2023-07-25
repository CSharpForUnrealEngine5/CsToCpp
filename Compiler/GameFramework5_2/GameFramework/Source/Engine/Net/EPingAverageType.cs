#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/NetPing.h")]
///<summary>The type of averaging to perform on ping values</summary>
public enum EPingAverageType {
	None=0,
	MovingAverage=1,
	PlayerStateAvg=2,
}
