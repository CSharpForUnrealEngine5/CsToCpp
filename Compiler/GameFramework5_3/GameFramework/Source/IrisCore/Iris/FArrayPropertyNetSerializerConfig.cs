namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Array property</summary>
[CppInclude("Iris/Serialization/InternalNetSerializers.h")]
public partial struct FArrayPropertyNetSerializerConfig {
	public ushort MaxElementCount;
	public ushort ElementCountBitCount;
	public object Property;
}
