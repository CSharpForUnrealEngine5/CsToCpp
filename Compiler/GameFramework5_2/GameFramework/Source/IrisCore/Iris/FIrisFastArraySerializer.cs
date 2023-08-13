namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialization of FFastArraySerializer in order to add state tracking support for Iris</summary>
[CppInclude("Iris/ReplicationState/IrisFastArraySerializer.h")]
public partial struct FIrisFastArraySerializer {
	public uint ChangeMaskStorage;
}
