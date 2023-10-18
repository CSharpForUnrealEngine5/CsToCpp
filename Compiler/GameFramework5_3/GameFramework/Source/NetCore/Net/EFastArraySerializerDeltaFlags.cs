namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Serialization/FastArraySerializer.h")]
public enum EFastArraySerializerDeltaFlags {
	None=0,
	HasBeenSerialized=-1,
	HasDeltaBeenRequested=-1,
	IsUsingDeltaSerialization=-1,
}
