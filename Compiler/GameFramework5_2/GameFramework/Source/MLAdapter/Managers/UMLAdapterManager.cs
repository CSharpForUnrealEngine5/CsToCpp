#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Managers/MLAdapterManager.h")]
///<summary>The manager of the MLAdapter system. Sets up the RPC server for communication with remote client. Based on settings,</summary>
public partial class UMLAdapterManager : UObject {
// MLAdapterManager
	public UMLAdapterSession Session;
	public UWorld LastActiveWorld;
	public FMLAdapterLibrarian Librarian;
}
