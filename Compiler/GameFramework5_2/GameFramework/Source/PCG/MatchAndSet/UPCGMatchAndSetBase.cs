#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for Match &amp; Set objects. Note that while it currently deals with points, it might be extended in the future.</summary>
[CppInclude("MatchAndSet/PCGMatchAndSetBase.h")]
public partial class UPCGMatchAndSetBase : UObject {
	///<summary>Early check to prevent issues when the data does not contain the required information to perform the operation</summary>
	public  bool ValidatePreconditions(UPCGPointData InPointData) { return default; }
	///<summary>Main function to process points, and pass them through the Match &amp; Set logic.</summary>
	public  void MatchAndSet(FPCGContext Context,UPCGPointMatchAndSetSettings InSettings,UPCGPointData InPointData,UPCGPointData OutPointData) {}
	///<summary>For the sake of managing internal state a bit better, we keep a copy of the Set type &amp; string subtype.</summary>
	public EPCGMetadataTypes Type;
	///<summary>StringMode</summary>
	public EPCGMetadataTypesConstantStructStringMode StringMode;
}
