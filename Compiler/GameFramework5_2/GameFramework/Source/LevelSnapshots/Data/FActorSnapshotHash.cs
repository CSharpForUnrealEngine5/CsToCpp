#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/ActorSnapshotHash.h")]
///<summary>Every actor is hashed when it is saved so we can quickly check whether an actor has changed.</summary>
public partial struct FActorSnapshotHash {
// ActorSnapshotHash
	public double MicroSecondsForCrc;
	public double MicroSecondsForMD5;
	public int Crc32DataLength;
	public int MD5DataLength;
	public uint Crc32;
}
