#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that controls how the baseline system behaves and also controls stats gathering for.</summary>
[CppInclude("NiagaraPerfBaseline.h")]
public partial class ANiagaraPerfBaselineActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Controller</summary>
	public UNiagaraBaselineController Controller;
	///<summary>Label</summary>
	public UTextRenderComponent Label;
}
