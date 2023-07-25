using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Engine/NetConnection.h")]
    public partial class UNetConnection : UPlayer {
    }

    [CppInclude("Engine/NetConnection.h")]
    public partial class USimulatedClientNetConnection : UNetConnection {
    }

}