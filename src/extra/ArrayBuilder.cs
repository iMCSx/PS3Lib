// ************************************************* //
//    --- Copyright (c) 2015 iMCS Productions ---    //
// ************************************************* //
//              PS3Lib v4 By FM|T iMCSx              //
//                                                   //
// Features v4.5 :                                   //
// - Support CCAPI v2.60+ C# by iMCSx.               //
// - Read/Write memory as 'double'.                  //
// - Read/Write memory as 'float' array.             //
// - Constructor overload for ArrayBuilder.          //
// - Some functions fixes.                           //
//                                                   //
// Credits : Enstone, Buc-ShoTz                      //
//                                                   //
// Follow me :                                       //
//                                                   //
// FrenchModdingTeam.com                             //
// Twitter.com/iMCSx                                 //
// Facebook.com/iMCSx                                //
//                                                   //
// ************************************************* //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS3Lib
{
    public enum EndianType
    {
        LittleEndian,
        BigEndian
    }

    public class ArrayBuilder
    {
        private byte[] buffer;
        private int size;

        public ArrayBuilder(byte[] BytesArray)
        {
            buffer = BytesArray;
            size = buffer.Length;
        }

        public ArrayBuilder(int arraySize)
        {
            buffer = new byte[arraySize];
            size = buffer.Length;
        }

        public byte[] ToArray()
        {
            return buffer;
        }

        /// <summary>Enter into all functions "Reader".</summary>
        public ArrayReader Read
        {
            get { return new ArrayReader(buffer); }
        }

        /// <summary>Enter into all functions "Writer".</summary>
        public ArrayWriter Write
        {
            get { return new ArrayWriter(buffer); }
        }

        public class ArrayReader
        {
            private byte[] buffer;
            private int size;

            public ArrayReader(byte[] BytesArray)
            {
                buffer = BytesArray;
                size = buffer.Length;
            }

            public sbyte GetSByte(int pos)
            {
                return (sbyte)buffer[pos];
            }

            public byte GetByte(int pos)
            {
                return buffer[pos];
            }

            public char GetChar(int pos)
            {
                string s = buffer[pos].ToString();
                char b = s[0];
                return b;
            }

            public bool GetBool(int pos)
            {
                return buffer[pos] != 0;
            }

            public short GetInt16(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[2];
                for(int i = 0; i < 2; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 2);
                return BitConverter.ToInt16(b, 0);
            }

            public int GetInt32(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[4];
                for (int i = 0; i < 4; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 4);
                return BitConverter.ToInt32(b, 0);
            }

            public long GetInt64(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 8);
                return BitConverter.ToInt64(b, 0);
            }

            public ushort GetUInt16(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[2];
                for (int i = 0; i < 2; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 2);
                return BitConverter.ToUInt16(b, 0);
            }

            public uint GetUInt32(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[4];
                for (int i = 0; i < 4; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 4);
                return BitConverter.ToUInt32(b, 0);
            }

            public ulong GetUInt64(int pos, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = new byte[8];
                for (int i = 0; i < 8; i++)
                    b[i] = buffer[pos + i];
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 8);
                return BitConverter.ToUInt64(b, 0);
            }

            public byte[] GetBytes(int pos, int length)
            {
                byte[] b = new byte[length];
                for (int i = 0; i < length; i++)
                    b[i] = buffer[pos + i];
                return b;
            }

            public string GetString(int pos)
            {
                int strlen = 0;
                while (true)
                {
                    if ((pos + strlen) == buffer.Length)
                        break;
                    if (buffer[pos + strlen] != (byte)0)
                        strlen++;
                    else break;
                }
                return Encoding.UTF8.GetString(
                    buffer.ToList()
                    .GetRange(pos, strlen)
                    .ToArray());
            }

            public float GetFloat(int pos)
            {
                byte[] b = new byte[4];
                for (int i = 0; i < 4; i++)
                    b[i] = buffer[pos+i];
                Array.Reverse(b, 0, 4);
                return BitConverter.ToSingle(b, 0);
            }
        }

        public class ArrayWriter
        {
            private byte[] buffer;
            private int size;

            public ArrayWriter(byte[] BytesArray)
            {
                buffer = BytesArray;
                size = buffer.Length;
            }

            public void SetSByte(int pos, sbyte value)
            {
                buffer[pos] = (byte)value;
            }

            public void SetByte(int pos, byte value)
            {
                buffer[pos] = value;
            }

            public void SetChar(int pos, char value)
            {
                byte[] b = Encoding.UTF8.GetBytes(value.ToString());
                buffer[pos] = b[0];
            }

            public void SetBool(int pos, bool value)
            {
                byte[] b = new byte[1];
                b[0] = value ? (byte)1 : (byte)0;
                buffer[pos] = b[0];
            }

            public void SetInt16(int pos, short value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 2);
                for (int i = 0; i < 2; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetInt32(int pos, int value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 4);
                for (int i = 0; i < 4; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetInt64(int pos, long value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 8);
                for (int i = 0; i < 8; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetUInt16(int pos, ushort value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 2);
                for (int i = 0; i < 2; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetUInt32(int pos, uint value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 4);
                for (int i = 0; i < 4; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetUInt64(int pos, ulong value, EndianType Type = EndianType.BigEndian)
            {
                byte[] b = BitConverter.GetBytes(value);
                if (Type == EndianType.BigEndian)
                    Array.Reverse(b, 0, 8);
                for (int i = 0; i < 8; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetBytes(int pos, byte[] value)
            {
                int valueSize = value.Length;
                for (int i = 0; i < valueSize; i++)
                    buffer[i + pos] = value[i];
            }

            public void SetString(int pos, string value)
            {
                byte[] b = Encoding.UTF8.GetBytes(value+"\0");
                for (int i = 0; i < b.Length; i++)
                    buffer[i + pos] = b[i];
            }

            public void SetFloat(int pos, float value)
            {
                byte[] b = BitConverter.GetBytes(value);
                Array.Reverse(b, 0, 4);
                for (int i = 0; i < 4; i++)
                    buffer[i + pos] = b[i];
            }
        }
    }
}
