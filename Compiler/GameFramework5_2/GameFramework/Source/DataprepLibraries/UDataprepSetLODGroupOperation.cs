namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, replace the existing static mesh&#39;s LODs with new ones based on selected group</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetLODGroupOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>GroupName</summary>
	public FName GroupName;
}
