namespace Interface
{
    internal interface ICar : IObject
    {
        /// <summary>
        /// Выполнить перемещение
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        int Move(int distance);
    }
}
