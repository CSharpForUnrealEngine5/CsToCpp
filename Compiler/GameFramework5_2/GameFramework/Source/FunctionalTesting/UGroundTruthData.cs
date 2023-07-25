#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroundTruthData.h")]
public partial class UGroundTruthData : UObject {
// GroundTruthData
	public void SaveObject(UObject GroundTruth) {}
	public UObject LoadObject() { return default; }
	public bool CanModify() { return default; }
	public bool bResetGroundTruth;
	public UObject ObjectData;
}
