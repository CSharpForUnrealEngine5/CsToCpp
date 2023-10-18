namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The current state of the AR subsystem including an optional explanation string.</summary>
[CppInclude("ARTypes.h")]
public partial struct FARSessionStatus {
	public string AdditionalInfo;
	public EARSessionStatus Status;
}
