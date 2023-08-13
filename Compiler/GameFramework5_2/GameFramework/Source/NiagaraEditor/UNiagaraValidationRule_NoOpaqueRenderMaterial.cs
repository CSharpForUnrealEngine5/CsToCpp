namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This validation rule is used by the collision module to check that renderers don&#39;t use any opaque or masked materials when depth buffer collisions are used.</summary>
[CppInclude("NiagaraValidationRules.h")]
public partial class UNiagaraValidationRule_NoOpaqueRenderMaterial : UNiagaraValidationRule {
	public static UClass StaticClass() {return default;}
}
