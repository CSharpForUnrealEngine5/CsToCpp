#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ENetRole. With role swapping at deserialization</summary>
[CppInclude("Iris/Serialization/InternalNetSerializers.h")]
public partial struct FNetRoleNetSerializerConfig {
	public int RelativeInternalOffsetToOtherRole;
	public int RelativeExternalOffsetToOtherRole;
	public byte LowerBound;
	public byte UpperBound;
	public byte BitCount;
	public byte AutonomousProxyValue;
	public byte SimulatedProxyValue;
}
