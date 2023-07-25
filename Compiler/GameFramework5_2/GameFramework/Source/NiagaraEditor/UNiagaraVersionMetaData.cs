#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraVersionMetaData.h")]
public partial class UNiagaraVersionMetaData : UObject {
// NiagaraVersionMetaData
	public bool bIsExposedVersion;
	public string ChangeDescription;
	public bool bIsVisibleInVersionSelector;
	public bool bDeprecated;
	public string DeprecationMessage;
	public FGuid VersionGuid;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public string PythonUpdateScript;
	public FFilePath ScriptAsset;
}
