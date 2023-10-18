namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to wrangle multiple input wires into one output wire for organizational purposes.</summary>
[CppInclude("Elements/PCGNumberOfPoints.h")]
public partial class UPCGNumberOfPointsSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>OutputAttributeName</summary>
	public FName OutputAttributeName;
}
