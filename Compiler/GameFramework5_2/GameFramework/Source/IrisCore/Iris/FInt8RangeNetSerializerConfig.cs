namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Integer range serializers</summary>
[CppInclude("Iris/Serialization/IntRangeNetSerializers.h")]
public partial struct FInt8RangeNetSerializerConfig {
	public short LowerBound;
	public short UpperBound;
	public byte BitCount;
}
