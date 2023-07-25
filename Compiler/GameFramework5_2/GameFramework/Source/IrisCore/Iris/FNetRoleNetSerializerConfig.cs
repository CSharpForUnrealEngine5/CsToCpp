#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Iris/Serialization/InternalNetSerializers.h")]
///<summary>ENetRole. With role swapping at deserialization</summary>
public partial struct FNetRoleNetSerializerConfig {
// NetRoleNetSerializerConfig
	public int RelativeInternalOffsetToOtherRole;
	public int RelativeExternalOffsetToOtherRole;
	public byte LowerBound;
	public byte UpperBound;
	public byte BitCount;
	public byte AutonomousProxyValue;
	public byte SimulatedProxyValue;
}
