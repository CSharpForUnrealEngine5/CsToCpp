namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGCopyPoints.h")]
public partial class UPCGCopyPointsSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The method used to determine output point rotation</summary>
	public EPCGCopyPointsInheritanceMode RotationInheritance;
	///<summary>The method used to determine output point scale</summary>
	public EPCGCopyPointsInheritanceMode ScaleInheritance;
	///<summary>The method used to determine output point color</summary>
	public EPCGCopyPointsInheritanceMode ColorInheritance;
	///<summary>The method used to determine output seed values. Relative recomputes the seed from the new location.</summary>
	public EPCGCopyPointsInheritanceMode SeedInheritance;
	///<summary>The method used to determine output data attributes</summary>
	public EPCGCopyPointsMetadataInheritanceMode AttributeInheritance;
}
