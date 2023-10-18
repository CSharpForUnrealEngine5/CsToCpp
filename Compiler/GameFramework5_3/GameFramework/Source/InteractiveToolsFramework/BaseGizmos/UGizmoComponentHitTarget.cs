namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UGizmoComponentHitTarget is an IGizmoClickTarget implementation that</summary>
[CppInclude("BaseGizmos/HitTargets.h")]
public partial class UGizmoComponentHitTarget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Component-&gt;LineTraceComponent() is called to determine if the target is hit</summary>
	public UPrimitiveComponent Component;
}
