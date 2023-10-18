namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset that points to an object to be detected in a scene</summary>
[CppInclude("ARTypes.h")]
public partial class UARCandidateObject : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>See: CandidateObjectData</summary>
	public TArray<byte> GetCandidateObjectData() { return default; }
	///<summary>SetCandidateObjectData</summary>
	public void SetCandidateObjectData(TArray<byte> InCandidateObject) {}
	///<summary>See: FriendlyName</summary>
	public string GetFriendlyName() { return default; }
	///<summary>SetFriendlyName</summary>
	public void SetFriendlyName(string NewName) {}
	///<summary>See: BoundingBox</summary>
	public FBox GetBoundingBox() { return default; }
	///<summary>SetBoundingBox</summary>
	public void SetBoundingBox(FBox InBoundingBox) {}
	///<summary>The object to detect in scenes</summary>
	public TArray<byte> CandidateObjectData;
	///<summary>The friendly name to report back when the object is detected in scenes</summary>
	public string FriendlyName;
	///<summary>The physical bounds in centimeters of the object that this candidate object represents</summary>
	public FBox BoundingBox;
}
