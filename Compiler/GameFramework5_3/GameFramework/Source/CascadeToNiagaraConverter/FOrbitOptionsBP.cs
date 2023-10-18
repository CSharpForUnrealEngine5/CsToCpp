namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>BlueprintType wrapper around FOrbitOptions to allow managing in blueprint/python logic.</summary>
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
public partial struct FOrbitOptionsBP {
	public bool bProcessDuringSpawn;
	public bool bProcessDuringUpdate;
	public bool bUseEmitterTime;
}
