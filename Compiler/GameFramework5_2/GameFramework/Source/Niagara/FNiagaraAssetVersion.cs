#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraAssetVersion {
	public int MajorVersion;
	public int MinorVersion;
	public FGuid VersionGuid;
	public bool bIsVisibleInVersionSelector;
}
