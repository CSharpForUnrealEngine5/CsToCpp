#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraPlatformSet.h")]
public partial struct FNiagaraPlatformSetConflictInfo {
	public int SetAIndex;
	public int SetBIndex;
	public TArray<FNiagaraPlatformSetConflictEntry> Conflicts;
}
