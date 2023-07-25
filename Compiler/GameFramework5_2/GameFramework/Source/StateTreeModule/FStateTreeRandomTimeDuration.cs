#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTypes.h")]
///<summary>Time duration with random variance. Stored compactly as two uint16s, which gives time range of about 650 seconds.</summary>
public partial struct FStateTreeRandomTimeDuration {
// StateTreeRandomTimeDuration
	public ushort Duration;
	public ushort RandomVariance;
}
