namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The manager of the MLAdapter system. Sets up the RPC server for communication with remote client. Based on settings,</summary>
[CppInclude("Managers/MLAdapterManager.h")]
public partial class UMLAdapterManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Session</summary>
	public UMLAdapterSession Session;
	///<summary>LastActiveWorld</summary>
	public UWorld LastActiveWorld;
	///<summary>Librarian</summary>
	public FMLAdapterLibrarian Librarian;
}
