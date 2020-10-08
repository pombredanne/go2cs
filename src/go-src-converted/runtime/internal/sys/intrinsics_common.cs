// Copyright 2019 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package sys -- go2cs converted at 2020 October 08 03:19:07 UTC
// import "runtime/internal/sys" ==> using sys = go.runtime.@internal.sys_package
// Original source: C:\Go\src\runtime\internal\sys\intrinsics_common.go

using static go.builtin;

namespace go {
namespace runtime {
namespace @internal
{
    public static partial class sys_package
    {
        // Copied from math/bits to avoid dependence.
        private static array<byte> len8tab = new array<byte>(new byte[] { 0x00, 0x01, 0x02, 0x02, 0x03, 0x03, 0x03, 0x03, 0x04, 0x04, 0x04, 0x04, 0x04, 0x04, 0x04, 0x04, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x05, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x06, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x07, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08 });

        private static array<byte> ntz8tab = new array<byte>(new byte[] { 0x08, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x05, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x06, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x05, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x07, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x05, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x06, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x05, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x04, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00, 0x03, 0x00, 0x01, 0x00, 0x02, 0x00, 0x01, 0x00 });

        // len64 returns the minimum number of bits required to represent x; the result is 0 for x == 0.
        public static long Len64(ulong x)
        {
            long n = default;

            if (x >= 1L << (int)(32L))
            {
                x >>= 32L;
                n = 32L;
            }

            if (x >= 1L << (int)(16L))
            {
                x >>= 16L;
                n += 16L;
            }

            if (x >= 1L << (int)(8L))
            {
                x >>= 8L;
                n += 8L;
            }

            return n + int(len8tab[x]);

        }

        // --- OnesCount ---

        private static readonly ulong m0 = (ulong)0x5555555555555555UL; // 01010101 ...
 // 01010101 ...
        private static readonly ulong m1 = (ulong)0x3333333333333333UL; // 00110011 ...
 // 00110011 ...
        private static readonly ulong m2 = (ulong)0x0f0f0f0f0f0f0f0fUL; // 00001111 ...

        // OnesCount64 returns the number of one bits ("population count") in x.
 // 00001111 ...

        // OnesCount64 returns the number of one bits ("population count") in x.
        public static long OnesCount64(ulong x)
        { 
            // Implementation: Parallel summing of adjacent bits.
            // See "Hacker's Delight", Chap. 5: Counting Bits.
            // The following pattern shows the general approach:
            //
            //   x = x>>1&(m0&m) + x&(m0&m)
            //   x = x>>2&(m1&m) + x&(m1&m)
            //   x = x>>4&(m2&m) + x&(m2&m)
            //   x = x>>8&(m3&m) + x&(m3&m)
            //   x = x>>16&(m4&m) + x&(m4&m)
            //   x = x>>32&(m5&m) + x&(m5&m)
            //   return int(x)
            //
            // Masking (& operations) can be left away when there's no
            // danger that a field's sum will carry over into the next
            // field: Since the result cannot be > 64, 8 bits is enough
            // and we can ignore the masks for the shifts by 8 and up.
            // Per "Hacker's Delight", the first line can be simplified
            // more, but it saves at best one instruction, so we leave
            // it alone for clarity.
            const long m = (long)1L << (int)(64L) - 1L;

            x = x >> (int)(1L) & (m0 & m) + x & (m0 & m);
            x = x >> (int)(2L) & (m1 & m) + x & (m1 & m);
            x = (x >> (int)(4L) + x) & (m2 & m);
            x += x >> (int)(8L);
            x += x >> (int)(16L);
            x += x >> (int)(32L);
            return int(x) & (1L << (int)(7L) - 1L);

        }

        private static array<byte> deBruijn64tab = new array<byte>(new byte[] { 0, 1, 56, 2, 57, 49, 28, 3, 61, 58, 42, 50, 38, 29, 17, 4, 62, 47, 59, 36, 45, 43, 51, 22, 53, 39, 33, 30, 24, 18, 12, 5, 63, 55, 48, 27, 60, 41, 37, 16, 46, 35, 44, 21, 52, 32, 23, 11, 54, 26, 40, 15, 34, 20, 31, 10, 25, 14, 19, 9, 13, 8, 7, 6 });

        private static readonly ulong deBruijn64 = (ulong)0x03f79d71b4ca8b09UL;

        // TrailingZeros64 returns the number of trailing zero bits in x; the result is 64 for x == 0.


        // TrailingZeros64 returns the number of trailing zero bits in x; the result is 64 for x == 0.
        public static long TrailingZeros64(ulong x)
        {
            if (x == 0L)
            {
                return 64L;
            } 
            // If popcount is fast, replace code below with return popcount(^x & (x - 1)).
            //
            // x & -x leaves only the right-most bit set in the word. Let k be the
            // index of that bit. Since only a single bit is set, the value is two
            // to the power of k. Multiplying by a power of two is equivalent to
            // left shifting, in this case by k bits. The de Bruijn (64 bit) constant
            // is such that all six bit, consecutive substrings are distinct.
            // Therefore, if we have a left shifted version of this constant we can
            // find by how many bits it was shifted by looking at which six bit
            // substring ended up at the top of the word.
            // (Knuth, volume 4, section 7.3.1)
            return int(deBruijn64tab[(x & -x) * deBruijn64 >> (int)((64L - 6L))]);

        }

        // LeadingZeros64 returns the number of leading zero bits in x; the result is 64 for x == 0.
        public static long LeadingZeros64(ulong x)
        {
            return 64L - Len64(x);
        }

        // LeadingZeros8 returns the number of leading zero bits in x; the result is 8 for x == 0.
        public static long LeadingZeros8(byte x)
        {
            return 8L - Len8(x);
        }

        // TrailingZeros8 returns the number of trailing zero bits in x; the result is 8 for x == 0.
        public static long TrailingZeros8(byte x)
        {
            return int(ntz8tab[x]);
        }

        // Len8 returns the minimum number of bits required to represent x; the result is 0 for x == 0.
        public static long Len8(byte x)
        {
            return int(len8tab[x]);
        }
    }
}}}