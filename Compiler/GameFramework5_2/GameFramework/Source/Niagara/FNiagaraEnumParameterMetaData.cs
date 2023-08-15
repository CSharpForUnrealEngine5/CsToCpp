namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines override data for enum parameters displayed in the UI.</summary>
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraEnumParameterMetaData {
	public FName OverrideName;
	public UTexture2D IconOverride;
	public bool bUseColorOverride;
	public FLinearColor ColorOverride;
}
