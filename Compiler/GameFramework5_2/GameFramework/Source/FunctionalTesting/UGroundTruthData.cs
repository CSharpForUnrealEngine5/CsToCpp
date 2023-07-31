#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroundTruthData.h")]
public partial class UGroundTruthData : UObject {
	///<summary>SaveObject</summary>
	public  void SaveObject(UObject GroundTruth) {}
	///<summary>LoadObject</summary>
	public  UObject LoadObject() { return default; }
	///<summary>CanModify</summary>
	public  bool CanModify() { return default; }
	///<summary>bResetGroundTruth</summary>
	public bool bResetGroundTruth;
	///<summary>ObjectData</summary>
	public UObject ObjectData;
}
