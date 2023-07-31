#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A handle to a lightweight entity.  An entity is used in conjunction with the FMassEntityManager</summary>
[CppInclude("MassEntityTypes.h")]
public partial struct FMassEntityHandle {
	public int Index;
	public int SerialNumber;
}
