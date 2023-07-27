#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Box scalar field that will be defined only within a box</summary>
public partial class UBoxFalloff : UFieldNodeFloat {
// BoxFalloff
	public  UBoxFalloff SetBoxFalloff(float Magnitude,float MinRange,float MaxRange,float Default,FTransform Transform,EFieldFalloffType Falloff) { return default; }
	public float Magnitude;
	public float MinRange;
	public float MaxRange;
	public float Default;
	public FTransform Transform;
	public byte Falloff;
}
