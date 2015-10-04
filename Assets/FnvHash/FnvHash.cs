namespace FnvHash
{
    public static class Hash32
    {
        const uint _fnv_prime = 16777619U;
        const uint _offset_basis = 2166136261U;

        public static uint Compute(uint x)
        {
            uint hval = _offset_basis;

            hval *= _fnv_prime;
            hval ^= x & 0xffU;

            hval *= _fnv_prime;
            hval ^= (x >> 8) & 0xffU;

            hval *= _fnv_prime;
            hval ^= (x >> 16) & 0xffU;

            hval *= _fnv_prime;
            hval ^= (x >> 24) & 0xffU;

            return hval;
        }

        public static uint Compute(uint x, uint hashSize)
        {
            return Compute(x) % hashSize;
        }

        public static int Compute(int x, int hashSize)
        {
            return (int)(Compute((uint)x) % (uint)hashSize);
        }
    }
}
