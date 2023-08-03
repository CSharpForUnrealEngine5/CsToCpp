#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraVersionMetaData.h")]
public partial class UNiagaraVersionMetaData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true then this version is exposed to the user and is used as the default version for new assets.</summary>
	public bool bIsExposedVersion;
	///<summary>Changelist displayed to the user when upgrading to a new script version.</summary>
	public string ChangeDescription;
	///<summary>If false then this version is not visible in the version selector dropdown menu of the stack. This is useful to hide work in progress versions without removing the module from the search menu.</summary>
	public bool bIsVisibleInVersionSelector;
	///<summary>True if this asset version is deprecated and should no longer be used.</summary>
	public bool bDeprecated;
	///<summary>Message to display when the asset is used in an emitter.</summary>
	public string DeprecationMessage;
	///<summary>Internal version guid, mainly useful for debugging version conflicts.</summary>
	public FGuid VersionGuid;
	///<summary>Reference to a python script that is executed when the user updates from a previous version to this version.</summary>
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	///<summary>Python script to run when updating to this script version.</summary>
	public string PythonUpdateScript;
	///<summary>Asset reference to a python script to run when updating to this script version.</summary>
	public FFilePath ScriptAsset;
}
