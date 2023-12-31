namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Time duration with random variance. Stored compactly as two uint16s, which gives time range of about 650 seconds.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeRandomTimeDuration {
	public ushort Duration;
	public ushort RandomVariance;
}
