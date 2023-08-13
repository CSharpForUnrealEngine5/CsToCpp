namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class that handles replication and only runs on the server. It queries Mass entity fragments and sets those values when appropriate using the MassClientBubbleHandler.</summary>
[CppInclude("MassCrowdReplicator.h")]
public partial class UMassCrowdReplicator : UMassReplicatorBase {
	public static UClass StaticClass() {return default;}
}
