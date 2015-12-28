using System.Net.Sockets;
using System.Text;

namespace GunFU
{
    public class StateObject
    {
        public const int BufferSize = 256;
        public Socket workSocket = null;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
}