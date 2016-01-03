using System.Net.Sockets;
using System.Text;

namespace GunFU
{
    public class BufferObject
    {
        public const int BufferSize = 1024;
        public Socket workSocket = null;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
}