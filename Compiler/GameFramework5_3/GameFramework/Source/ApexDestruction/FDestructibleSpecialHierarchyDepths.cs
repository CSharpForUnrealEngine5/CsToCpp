namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Special hierarchy depths for various behaviors.</summary>
[CppInclude("DestructibleMesh.h")]
public partial struct FDestructibleSpecialHierarchyDepths {
	public int SupportDepth;
	public int MinimumFractureDepth;
	public bool bEnableDebris;
	public int DebrisDepth;
	public int EssentialDepth;
}
