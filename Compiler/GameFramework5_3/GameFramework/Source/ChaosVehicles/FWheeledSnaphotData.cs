namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SnapshotData.h")]
public partial struct FWheeledSnaphotData {
	public int SelectedGear;
	public float EngineRPM;
	public TArray<FWheelSnapshot> WheelSnapshots;
}
