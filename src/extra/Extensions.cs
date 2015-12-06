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

namespace PS3Lib
{
    public class Extension
    {
        private SelectAPI CurrentAPI;
        public Extension(SelectAPI API)
        {
            CurrentAPI = API;
            if (API == SelectAPI.TargetManager)
                if (Common.TmApi == null)
                    Common.TmApi = new TMAPI();
            if (API == SelectAPI.ControlConsole)
                if (Common.CcApi == null)
                    Common.CcApi = new CCAPI();
        }

        /// <summary>Read a signed byte.</summary>
        public sbyte ReadSByte(uint offset)
        {
            byte[] buffer = new byte[1];
            GetMem(offset, buffer, CurrentAPI);
            return (sbyte)buffer[0];
        }

        /// <summary>Read a byte a check if his value. This return a bool according the byte detected.</summary>
        public bool ReadBool(uint offset)
        {
            byte[] buffer = new byte[1];
            GetMem(offset, buffer, CurrentAPI);
            return buffer[0] != 0;
        }

        /// <summary>Read and return an integer 16 bits.</summary>
        public short ReadInt16(uint offset)
        {
            byte[] buffer = GetBytes(offset, 2, CurrentAPI);
            Array.Reverse(buffer, 0, 2);
            return BitConverter.ToInt16(buffer, 0);
        }

        /// <summary>Read and return an integer 32 bits.</summary>
        public int ReadInt32(uint offset)
        {
            byte[] buffer = GetBytes(offset, 4, CurrentAPI);
            Array.Reverse(buffer, 0, 4);
            return BitConverter.ToInt32(buffer, 0);
        }

        /// <summary>Read and return an integer 64 bits.</summary>
        public long ReadInt64(uint offset)
        {
            byte[] buffer = GetBytes(offset, 8, CurrentAPI);
            Array.Reverse(buffer, 0, 8);
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>Read and return a byte.</summary>
        public byte ReadByte(uint offset)
        {
            byte[] buffer = GetBytes(offset, 1, CurrentAPI);
            return buffer[0];
        }

        /// <summary>Read a string with a length to the first byte equal to an value null (0x00).</summary>
        public byte[] ReadBytes(uint offset, int length)
        {
            byte[] buffer = GetBytes(offset, (uint)length, CurrentAPI);
            return buffer;
        }

        /// <summary>Read and return an unsigned integer 16 bits.</summary>
        public ushort ReadUInt16(uint offset)
        {
            byte[] buffer = GetBytes(offset, 2, CurrentAPI);
            Array.Reverse(buffer, 0, 2);
            return BitConverter.ToUInt16(buffer, 0);
        }

        /// <summary>Read and return an unsigned integer 32 bits.</summary>
        public uint ReadUInt32(uint offset)
        {
            byte[] buffer = GetBytes(offset, 4, CurrentAPI);
            Array.Reverse(buffer, 0, 4);
            return BitConverter.ToUInt32(buffer, 0);
        }

        /// <summary>Read and return an unsigned integer 64 bits.</summary>
        public ulong ReadUInt64(uint offset)
        {
            byte[] buffer = GetBytes(offset, 8, CurrentAPI);
            Array.Reverse(buffer, 0, 8);
            return BitConverter.ToUInt64(buffer, 0);
        }

        /// <summary>Read and return a Float.</summary>
        public float ReadFloat(uint offset)
        {
            byte[] buffer = GetBytes(offset, 4, CurrentAPI);
            Array.Reverse(buffer, 0, 4);
            return BitConverter.ToSingle(buffer, 0);
        }

        /// <summary>Read and return an array of Floats.</summary>
        public float[] ReadFloats(uint offset, int arrayLength = 3)
        {
            float[] vec = new float[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                byte[] buffer = GetBytes(offset + ((uint)i*4), 4, CurrentAPI);
                Array.Reverse(buffer, 0, 4);
                vec[i] = BitConverter.ToSingle(buffer, 0);
            }
            return vec;
        }

        /// <summary>Read and return a Double.</summary>
        public double ReadDouble(uint offset)
        {
            byte[] buffer = GetBytes(offset, 8, CurrentAPI);
            Array.Reverse(buffer, 0, 8);
            return BitConverter.ToDouble(buffer, 0);
        }

        /// <summary>Read a string very fast by buffer and stop only when a byte null is detected (0x00).</summary>
        public string ReadString(uint offset)
        {
            int blocksize = 40;
            int scalesize = 0;
            string str = string.Empty;

            while (!str.Contains('\0'))
            {
                byte[] buffer = ReadBytes(offset + (uint)scalesize, blocksize);
                str += Encoding.UTF8.GetString(buffer);
                scalesize += blocksize;
            }

            return str.Substring(0, str.IndexOf('\0'));
        }

        /// <summary>Write a signed byte.</summary>
        public void WriteSByte(uint offset, sbyte input)
        {
            byte[] buff = new byte[1];
            buff[0] = (byte)input;
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write a boolean.</summary>
        public void WriteBool(uint offset, bool input)
        {
            byte[] buff = new byte[1];
            buff[0] = input ? (byte)1 : (byte)0;
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an interger 16 bits.</summary>
        public void WriteInt16(uint offset, short input)
        {
            byte[] buff = new byte[2];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 2);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an integer 32 bits.</summary>
        public void WriteInt32(uint offset, int input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 4);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an integer 64 bits.</summary>
        public void WriteInt64(uint offset, long input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 8);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write a byte.</summary>
        public void WriteByte(uint offset, byte input)
        {
            byte[] buff = new byte[1];
            buff[0] = input;
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write a byte array.</summary>
        public void WriteBytes(uint offset, byte[] input)
        {
            byte[] buff = input;
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write a string.</summary>
        public void WriteString(uint offset, string input)
        {
            byte[] buff = Encoding.UTF8.GetBytes(input);
            Array.Resize(ref buff, buff.Length + 1);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an unsigned integer 16 bits.</summary>
        public void WriteUInt16(uint offset, ushort input)
        {
            byte[] buff = new byte[2];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 2);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an unsigned integer 32 bits.</summary>
        public void WriteUInt32(uint offset, uint input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 4);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an unsigned integer 64 bits.</summary>
        public void WriteUInt64(uint offset, ulong input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 8);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write a Float.</summary>
        public void WriteFloat(uint offset, float input)
        {
            byte[] buff = new byte[4];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 4);
            SetMem(offset, buff, CurrentAPI);
        }

        /// <summary>Write an array of Floats.</summary>
        public void WriteFloats(uint offset, float[] input)
        {
            byte[] buff = new byte[4];
            for (int i = 0; i < input.Length; i++)
            {
                BitConverter.GetBytes(input[i]).CopyTo(buff, 0);
                Array.Reverse(buff, 0, 4);
                SetMem(offset+((uint)i*4), buff, CurrentAPI);
            }
        }

        /// <summary>Write a double.</summary>
        public void WriteDouble(uint offset, double input)
        {
            byte[] buff = new byte[8];
            BitConverter.GetBytes(input).CopyTo(buff, 0);
            Array.Reverse(buff, 0, 8);
            SetMem(offset, buff, CurrentAPI);
        }

        private void SetMem(uint Address, byte[] buffer, SelectAPI API)
        {
            if (API == SelectAPI.ControlConsole)
                Common.CcApi.SetMemory(Address, buffer);
            else if (API == SelectAPI.TargetManager)
                Common.TmApi.SetMemory(Address, buffer);
        }

        private void GetMem(uint offset, byte[] buffer, SelectAPI API)
        {
            if (API == SelectAPI.ControlConsole)
                Common.CcApi.GetMemory(offset, buffer);
            else if (API == SelectAPI.TargetManager)
                Common.TmApi.GetMemory(offset, buffer);
        }

        private byte[] GetBytes(uint offset, uint length, SelectAPI API)
        {
            byte[] buffer = new byte[length];
            if (API == SelectAPI.ControlConsole)
                buffer = Common.CcApi.GetBytes(offset, length);
            else if (API == SelectAPI.TargetManager)
                buffer = Common.TmApi.GetBytes(offset, length);
            return buffer;
        }

        private class Common
        {
            public static CCAPI CcApi;
            public static TMAPI TmApi;
        }

    }
}