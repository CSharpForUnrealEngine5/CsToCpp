namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>: public UObject</summary>
[CppInclude("SnapshotData.h")]
public partial struct FBaseSnapshotData {
	public FTransform Transform;
	public FVector LinearVelocity;
	public FVector AngularVelocity;
}
