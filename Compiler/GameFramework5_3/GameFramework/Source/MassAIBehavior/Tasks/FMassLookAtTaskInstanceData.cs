namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Task to assign a LookAt target for mass processing</summary>
[CppInclude("Tasks/MassLookAtTask.h")]
public partial struct FMassLookAtTaskInstanceData {
	public FMassEntityHandle TargetEntity;
	public float Duration;
	public float Time;
}
