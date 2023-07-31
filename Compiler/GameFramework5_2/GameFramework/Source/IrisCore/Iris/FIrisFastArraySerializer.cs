#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specialization of FFastArraySerializer in order to add state tracking support for Iris</summary>
[CppInclude("Iris/ReplicationState/IrisFastArraySerializer.h")]
public partial struct FIrisFastArraySerializer {
	public uint ChangeMaskStorage;
}
