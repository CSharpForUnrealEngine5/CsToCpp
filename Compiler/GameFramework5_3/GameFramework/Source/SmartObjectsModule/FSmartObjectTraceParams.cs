namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to define how traces should be handled.</summary>
[CppInclude("SmartObjectTypes.h")]
public partial struct FSmartObjectTraceParams {
	public ESmartObjectTraceType Type;
	public ETraceTypeQuery TraceChannel;
	public TArray<EObjectTypeQuery> ObjectTypes;
	public FCollisionProfileName CollisionProfile;
	public bool bTraceComplex;
}
