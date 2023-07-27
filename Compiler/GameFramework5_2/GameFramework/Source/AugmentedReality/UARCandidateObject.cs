#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>An asset that points to an object to be detected in a scene</summary>
public partial class UARCandidateObject : UDataAsset {
// ARCandidateObject
	public  TArray<byte> GetCandidateObjectData() { return default; }
	public  void SetCandidateObjectData(TArray<byte> InCandidateObject) {}
	public  string GetFriendlyName() { return default; }
	public  void SetFriendlyName(string NewName) {}
	public  FBox GetBoundingBox() { return default; }
	public  void SetBoundingBox(FBox InBoundingBox) {}
	public TArray<byte> CandidateObjectData;
	public string FriendlyName;
	public FBox BoundingBox;
}
