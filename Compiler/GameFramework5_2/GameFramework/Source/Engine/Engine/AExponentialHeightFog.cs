#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ExponentialHeightFog.h")]
///<summary>Implements an Actor for exponential height fog.</summary>
public partial class AExponentialHeightFog : AInfo {
// ExponentialHeightFog
	public UExponentialHeightFogComponent Component;
	public bool bEnabled;
	public  void OnRep_bEnabled() {}
}
