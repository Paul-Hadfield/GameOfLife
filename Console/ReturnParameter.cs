namespace GameOfLife
{
    public static class ReturnParameter
    {
        public static T OrThrowIfNull<T>(T obj, string name)
        {
            Throw.IfNull(obj, name);

            return obj;
        }
    }
}