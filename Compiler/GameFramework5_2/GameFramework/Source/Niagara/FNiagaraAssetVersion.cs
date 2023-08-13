namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraAssetVersion {
	public int MajorVersion;
	public int MinorVersion;
	public FGuid VersionGuid;
	public bool bIsVisibleInVersionSelector;
}
