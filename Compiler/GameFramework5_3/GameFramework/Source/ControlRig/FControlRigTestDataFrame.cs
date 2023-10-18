namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigTestData.h")]
public partial struct FControlRigTestDataFrame {
	public double AbsoluteTime;
	public double DeltaTime;
	public TArray<FControlRigTestDataVariable> Variables;
	public FRigPose Pose;
}
